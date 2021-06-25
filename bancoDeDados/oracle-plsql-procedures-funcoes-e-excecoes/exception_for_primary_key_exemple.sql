SELECT * FROM CLIENTE;

EXECUTE INCLUIR_CLIENTE('10', 'MERCADO PPP', '40000', 1,12000);


EXECUTE INCLUIR_CLIENTE('1', 'MERCADO AAA', '45677', 1,90000);

SET SERVEROUTPUT ON;

create or replace NONEDITIONABLE PROCEDURE INCLUIR_CLIENTE

(p_ID IN CLIENTE.ID%TYPE, p_RAZAO_SOCIAL IN CLIENTE.RAZAO_SOCIAL%TYPE,
 p_CNPJ IN CLIENTE.CNPJ%TYPE, p_SEGMERCADO_ID IN CLIENTE.SEGMERCADO_ID%TYPE,
 p_FATURAMENTO_PREVISTO IN CLIENTE.FATURAMENTO_PREVISTO%TYPE)
 
IS
    v_CATEGORIA CLIENTE.CATEGORIA%TYPE;
    v_CNPJ CLIENTE.CNPJ%TYPE := p_CNPJ;

BEGIN 
    FORMATA_CNPJ(v_CNPJ);
     v_CATEGORIA := CATEGORIA_CLIENTE(p_FATURAMENTO_PREVISTO);

    INSERT INTO CLIENTE (ID, RAZAO_SOCIAL, CNPJ, SEGMERCADO_ID, DATA_INCLUSAO, FATURAMENTO_PREVISTO, CATEGORIA)
    VALUES
    (p_ID, p_RAZAO_SOCIAL, v_CNPJ, p_SEGMERCADO_ID, SYSDATE, p_FATURAMENTO_PREVISTO,v_CATEGORIA);

    COMMIT;
    
EXCEPTION

WHEN DUP_VAL_ON_INDEX THEN
-- DUP_VAL_ON_INDEX == ERROS DO TIPO CHAVE PRIM�RIA DUPLICADA
    DBMS_OUTPUT.PUT_LINE ('CLIENTE J� CADASTRADO!!');
END;