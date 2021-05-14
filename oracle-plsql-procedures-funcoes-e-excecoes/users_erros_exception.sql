create or replace PROCEDURE ATUALIZAR_CLI_SEG_MERCADO
(p_ID CLIENTE.ID%TYPE, p_SEGMERCADO_ID CLIENTE.SEGMERCADO_ID%TYPE)
IS
    e_CLIENTE_ID_INEXISTENTE EXCEPTION;
BEGIN
    UPDATE CLIENTE SET SEGMERCADO_ID = p_SEGMERCADO_ID
    WHERE ID = p_ID;
    IF SQL%NOTFOUND THEN
-- SQL RECEBE O N�MERO DE LINHAS ATUALIZADAS.
-- SE SQL == 0 que no caso �: NOTFOUND, ELE EXECUTA O ERRO;
        RAISE e_CLIENTE_ID_INEXISTENTE;
--      RAISE COM PARAMETRO UMA VARI�VEL DE EXCE��O, FOR�AR� UM ERRO.   
    END IF;
    COMMIT;
EXCEPTION 
    WHEN e_CLIENTE_ID_INEXISTENTE THEN
        RAISE_APPLICATION_ERROR(-20100, 'Cliente inexistente');
END;

EXECUTE ATUALIZAR_CLI_SEG_MERCADO(15,2)
-- PAR�METROS DECLARADOS: PRIMERIO == ID; SEGUNDO == SEGMERCADO