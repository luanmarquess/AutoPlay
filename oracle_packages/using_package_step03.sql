EXECUTE CLIENTE_PAC.INCLUIR_CLIENTE(10,'PRIMEIRO CLIENTE INCLUIDO POR USER_APP VIA PACKAGE', '45678', 2, 120000);
-- EXECUTE + SINONIMO_PACKAGE.NOME_PROCEDURE(DADOS SEQU�NCIAS PASSADOS COMO PAR�METRO DA PROCEDURE);
-- USER CALL PROCEDURE "INCLUIR_CLIENTE" THAT IS INCLUIDED AT THE PACKAGE "CLIENTE_PAC" FROM THE OWNER "user_dev"

SELECT * FROM CLIENTE;