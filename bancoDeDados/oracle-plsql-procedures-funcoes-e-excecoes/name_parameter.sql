SELECT * FROM CLIENTE;

DECLARE 
    v_SEGMERCADO_ID CLIENTE.SEGMERCADO_ID%TYPE := 1;
BEGIN
    FOR v_ID IN 1..6 LOOP
    -- vari�vel v_1 come�a em 1 e vai at� 6
    ATUALIZAR_CLI_SEG_MERCADO(p_ID => v_ID, p_SEGMERCADO_ID => v_SEGMERCADO_ID);
    --                NOME_PAR�METRO, VALOR_RECEBIDO
    END LOOP;
END;