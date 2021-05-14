DECLARE
    CURSOR cur_CLIENTE IS SELECT ID FROM CLIENTE;
--  CURSOR � UMA VARI�VEL. cur_ � uma boa pr�tica para declara��o de cursor. SELECT CONSULTA DA TABELA QUE QUERO;
-- O resultado do select tem seus dados associados a vari�vel cur_cliente;

    v_SEGMERCADO_ID CLIENTE.SEGMERCADO_ID%TYPE := 1;
-- VARI�VEIS DE TRABALHO PARA PERCORRER O CURSOR;
BEGIN   
    FOR cli_rec IN cur_CLIENTE LOOP
   -- PERCORRE TODAS A LINHAS DO CURSOR E ATRIBUI O SEU VALOR AO ARRAY cli_rec;
   -- cli_rec ter� o n�mero de posi��es iguais ao n�mero de colunas do SELECT;
     ATUALIZAR_CLI_SEG_MERCADO(p_SEGMERCADO_ID => v_SEGMERCADO_ID, p_ID =>cli_rec.ID);
                                                            -- cli_rec.ID referenciado do array cli_rec
    END LOOP; 
END;

SELECT * FROM CLIENTE;