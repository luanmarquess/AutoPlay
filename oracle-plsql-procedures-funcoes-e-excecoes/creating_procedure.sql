CREATE OR REPLACE PROCEDURE INCLUIR_CLIENTE

(p_ID IN CLIENTE.ID%TYPE, p_RAZAO_SOCIAL IN CLIENTE.RAZAO_SOCIAL%TYPE,
 p_CNPJ IN CLIENTE.CNPJ%TYPE, p_SEGMERCADO_ID IN CLIENTE.SEGMERCADO_ID%TYPE,
 p_FATURAMENTO_PREVISTO IN CLIENTE.FATURAMENTO_PREVISTO%TYPE)
 
IS

BEGIN 
    INSERT INTO CLIENTE (ID, RAZAO_SOCIAL, CNPJ, SEGMERCADO_ID, DATA_INCLUSAO, FATURAMENTO_PREVISTO, CATEGORIA)
    VALUES
    (p_ID, p_RAZAO_SOCIAL, p_CNPJ, p_SEGMERCADO_ID, SYSDATE, p_FATURAMENTO_PREVISTO,'000000');
    
    COMMIT;

END;

EXECUTE INCLUIR_CLIENTE (2, 'SUPERMERCADO IJK', '67890', 1, 90000);

SELECT * FROM CLIENTE