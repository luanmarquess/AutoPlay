SELECT * FROM CLIENTE;

DECLARE 
    v_SEGMERCADO_ID CLIENTE.SEGMERCADO_ID%TYPE := 3;
BEGIN
    FOR v_ID IN 1..6 LOOP
    -- vari�vel v_1 come�a em 1 e vai at� 6
    ATUALIZAR_CLI_SEG_MERCADO(v_ID, v_SEGMERCADO_ID);
    END LOOP;
END;
