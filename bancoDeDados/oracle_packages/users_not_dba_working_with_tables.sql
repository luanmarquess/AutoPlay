INSERT INTO user_dev.CLIENTE (ID, RAZAO_SOCIAL) VALUES (5, 'PADARIA DEF');
-- user_dev.CLIENTE. A tabela CLIENTE � de dom�nio do user_dev e est� armazenada em seu acesso. Para acessa-la,
-- al�m da permiss�o, necessita refer�ncia-la com o nome do usu�rio.NomeTabela;

EXECUTE user_dev.INCLUIR_CLIENTE(5, 'Primeiro Cliente incluido por USER_APP', '23456', 2, 100000);

SELECT * FROM user_dev.CLIENTE;