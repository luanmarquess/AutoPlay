INSERT INTO user_dev.CLIENTE (ID, RAZAO_SOCIAL) VALUES (5, 'PADARIA DEF');
-- user_dev.CLIENTE. A tabela CLIENTE é de domínio do user_dev e está armazenada em seu acesso. Para acessa-la,
-- além da permissão, necessita referência-la com o nome do usuário.NomeTabela;

EXECUTE user_dev.INCLUIR_CLIENTE(5, 'Primeiro Cliente incluido por USER_APP', '23456', 2, 100000);

SELECT * FROM user_dev.CLIENTE;