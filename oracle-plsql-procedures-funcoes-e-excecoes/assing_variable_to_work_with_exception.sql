EXECUTE INCLUIR_CLIENTE(null, 'MERCADO AAA', '45677', 1,90000);

create or replace NONEDITIONABLE PROCEDURE INCLUIR_CLIENTE

(p_ID IN CLIENTE.ID%TYPE, p_RAZAO_SOCIAL IN CLIENTE.RAZAO_SOCIAL%TYPE,
 p_CNPJ IN CLIENTE.CNPJ%TYPE, p_SEGMERCADO_ID IN CLIENTE.SEGMERCADO_ID%TYPE,
 p_FATURAMENTO_PREVISTO IN CLIENTE.FATURAMENTO_PREVISTO%TYPE) 
 
IS
    v_CATEGORIA CLIENTE.CATEGORIA%TYPE;
    v_CNPJ CLIENTE.CNPJ%TYPE := p_CNPJ;
    e_null exception;
-- e == variável do tipo exeption;
    pragma exception_init(e_null, -1400);
-- caso o erro -1400 aconteça, ele é atribuido a variável e_null;

BEGIN 
    FORMATA_CNPJ(v_CNPJ);
     v_CATEGORIA := CATEGORIA_CLIENTE(p_FATURAMENTO_PREVISTO);

    INSERT INTO CLIENTE (ID, RAZAO_SOCIAL, CNPJ, SEGMERCADO_ID, DATA_INCLUSAO, FATURAMENTO_PREVISTO, CATEGORIA)
    VALUES
    (p_ID, p_RAZAO_SOCIAL, v_CNPJ, p_SEGMERCADO_ID, SYSDATE, p_FATURAMENTO_PREVISTO,v_CATEGORIA);

    COMMIT;
    
EXCEPTION

    WHEN DUP_VAL_ON_INDEX THEN
    -- DUP_VAL_ON_INDEX == ERROS DO TIPO CHAVE PRIMÁRIA DUPLICADA
        raise_application_error(-20010, 'Cliente já cadastrado!');
    --                         CÓDIGO DO ERRO, DESCRIÇÃO A SER EXIBIDA;
    -- raise_application_error == PROCEDURE QUE LANÇA EXCEÇÃO COM MENSAGEM COSTUMIZADA, NÃO TENDO QUE HABILITAR O SET SERVEROUTPUT;
    WHEN e_null THEN
        raise_application_error(-20015, 'Coluna ID não pode receber nulo ou vazio!');
    --                          código que eu atribuo a  mensagem.
    -- Oracle disponibiliza do -20000 ao -20999, para o usuário atribuir erros;
END;