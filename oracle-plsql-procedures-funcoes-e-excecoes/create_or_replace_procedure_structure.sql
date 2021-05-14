CREATE OR REPLACE PROCEDURE INCLUIR_SEGMERCADO (p_ID SEGMERCADO.ID%TYPE, p_DESCRICAO SEGMERCADO.DESCRICAO%TYPE)
--CREATE PROCEDURE NOME_PROCEDURE (PAR�METROS)
-- CREATE OR REPLACE = CRIA OU SUBSTITUI ALGUM EXISTENTE;
-- %TYPE = IR� DECLARAR A VARI�VEL COM O MESMO TIPO DO CAMPO DECLARADO NA TABELA, EVITANDO ERROS;
IS
-- DECLARAR AS VARI�VEIS USADAS NA PROCEDURE;
BEGIN
    INSERT INTO SEGMERCADO (ID, DESCRICAO) VALUES (p_ID, UPPER(p_DESCRICAO));
    COMMIT;
END;

