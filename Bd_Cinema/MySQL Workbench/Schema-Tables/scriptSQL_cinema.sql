-- creating schema
CREATE SCHEMA CINEMA;

-- creating tables
CREATE TABLE TB_SETOR (
                NUM INT NOT NULL,
                NOME VARCHAR(50) NOT NULL,
                PRIMARY KEY (NUM)
);


CREATE TABLE TB_CLIENTE (
                CPF VARCHAR(11) NOT NULL,
                NOME VARCHAR(150) NOT NULL,
                PRIMARY KEY (CPF)
);


CREATE TABLE SALA (
                NUM VARCHAR(2) NOT NULL,
                TIPO VARCHAR(2) NOT NULL,
                PRIMARY KEY (NUM)
);


CREATE TABLE TB_ASSENTO (
                NUM VARCHAR(2) NOT NULL,
                COD VARCHAR(3) NOT NULL,
                PRIMARY KEY (NUM, COD)
);


CREATE TABLE TB_BILHETE (
                COD VARCHAR(5) NOT NULL,
                CPF VARCHAR(11) NOT NULL,
                NUM VARCHAR(2) NOT NULL,
                ASSENTO_COD VARCHAR(3) NOT NULL,
                TIPO VARCHAR(7) NOT NULL,
                PRIMARY KEY (COD, CPF, NUM, ASSENTO_COD)
);


CREATE TABLE TB_FUNCIONARIO (
                CPF VARCHAR(11) NOT NULL,
                NUM INT NOT NULL,
                SEXO VARCHAR(1) NOT NULL,
                PRIMEIRO_NOME VARCHAR(50) NOT NULL,
                NOME_MEIO VARCHAR(50) NOT NULL,
                ENDERECO VARCHAR(200) NOT NULL,
                ULTIMO_NOME VARCHAR(50) NOT NULL,
                DATA_NASCIMENTO DATE NOT NULL,
                PRIMARY KEY (CPF, NUM)
);


CREATE TABLE TB_GERENTE (
                CPF VARCHAR(11) NOT NULL,
                NUM INT NOT NULL,
                DATA_INICIO DATE NOT NULL,
                PRIMARY KEY (CPF, NUM)
);


CREATE TABLE TB_DEPENDENTE (
                NOME VARCHAR(150) NOT NULL,
                CPF VARCHAR(11) NOT NULL,
                SEXO VARCHAR(1) NOT NULL,
                DATA_NASCIMENTO DATE NOT NULL,
                PARENTESCO VARCHAR(7) NOT NULL,
                PRIMARY KEY (NOME, CPF)
);


CREATE TABLE TB_PRODUTORA (
                NOME VARCHAR(150) NOT NULL,
                CNPJ VARCHAR(14) NOT NULL,
                ENDERECO VARCHAR(200) NOT NULL,
                PRIMARY KEY (NOME, CNPJ)
);


CREATE TABLE TB_FILME (
                TITULO VARCHAR(150) NOT NULL,
                NOME VARCHAR(150) NOT NULL,
                DATA_LANCAMENTO DATE NOT NULL,
                SINOPSE VARCHAR(500) NOT NULL,
                PRIMARY KEY (TITULO, NOME)
);


CREATE TABLE TB_CINEMA (
                NOME VARCHAR(150) NOT NULL,
                CNPJ VARCHAR(14) NOT NULL,
                CPF VARCHAR(11) NOT NULL,
                FUNCIONARIO_NUM INT NOT NULL,
                ENDERECO VARCHAR(200) NOT NULL,
                PRIMARY KEY (NOME, CNPJ, CPF, FUNCIONARIO_NUM)
);


CREATE TABLE TB_SESSAO (
                ID VARCHAR(5) NOT NULL,
                TITULO VARCHAR(150) NOT NULL,
                NOME VARCHAR(150) NOT NULL,
                NUM VARCHAR(2) NOT NULL,
                CNPJ VARCHAR(14) NOT NULL,
                CPF VARCHAR(11) NOT NULL,
                FUNCIONARIO_NUM INT NOT NULL,
                PRIMARY KEY (ID, TITULO, NOME, NUM, CNPJ, CPF, FUNCIONARIO_NUM)
);


ALTER TABLE TB_FUNCIONARIO ADD CONSTRAINT tb_setor_tb_funcionario_fk
FOREIGN KEY (NUM)
REFERENCES TB_SETOR (NUM)
ON DELETE NO ACTION
ON UPDATE NO ACTION;

ALTER TABLE TB_GERENTE ADD CONSTRAINT tb_setor_tb_gerente_fk
FOREIGN KEY (NUM)
REFERENCES TB_SETOR (NUM)
ON DELETE NO ACTION
ON UPDATE NO ACTION;

ALTER TABLE TB_BILHETE ADD CONSTRAINT tb_cliente_tb_bilhete_fk
FOREIGN KEY (CPF)
REFERENCES TB_CLIENTE (CPF)
ON DELETE NO ACTION
ON UPDATE NO ACTION;

ALTER TABLE TB_ASSENTO ADD CONSTRAINT sala_tb_assento_fk
FOREIGN KEY (NUM)
REFERENCES SALA (NUM)
ON DELETE NO ACTION
ON UPDATE NO ACTION;

ALTER TABLE TB_BILHETE ADD CONSTRAINT sala_tb_bilhete_fk
FOREIGN KEY (NUM)
REFERENCES SALA (NUM)
ON DELETE NO ACTION
ON UPDATE NO ACTION;

ALTER TABLE TB_SESSAO ADD CONSTRAINT sala_tb_sessao_fk
FOREIGN KEY (NUM)
REFERENCES SALA (NUM)
ON DELETE NO ACTION
ON UPDATE NO ACTION;

ALTER TABLE TB_BILHETE ADD CONSTRAINT tb_assento_tb_bilhete_fk
FOREIGN KEY (NUM, ASSENTO_COD)
REFERENCES TB_ASSENTO (NUM, COD)
ON DELETE NO ACTION
ON UPDATE NO ACTION;

ALTER TABLE TB_DEPENDENTE ADD CONSTRAINT tb_funcionario_tb_dependente_fk
FOREIGN KEY (CPF)
REFERENCES TB_FUNCIONARIO (CPF)
ON DELETE NO ACTION
ON UPDATE NO ACTION;

ALTER TABLE TB_GERENTE ADD CONSTRAINT tb_funcionario_tb_gerente_fk
FOREIGN KEY (CPF)
REFERENCES TB_FUNCIONARIO (CPF)
ON DELETE NO ACTION
ON UPDATE NO ACTION;

ALTER TABLE TB_CINEMA ADD CONSTRAINT tb_funcionario_tb_cinema_fk
FOREIGN KEY (FUNCIONARIO_NUM, CPF)
REFERENCES TB_FUNCIONARIO (NUM, CPF)
ON DELETE NO ACTION
ON UPDATE NO ACTION;

ALTER TABLE TB_FILME ADD CONSTRAINT tb_produtora_tb_filme_fk
FOREIGN KEY (NOME)
REFERENCES TB_PRODUTORA (NOME)
ON DELETE NO ACTION
ON UPDATE NO ACTION;

ALTER TABLE TB_SESSAO ADD CONSTRAINT tb_filme_tb_sessao_fk
FOREIGN KEY (TITULO, NOME)
REFERENCES TB_FILME (TITULO, NOME)
ON DELETE NO ACTION
ON UPDATE NO ACTION;

ALTER TABLE TB_SESSAO ADD CONSTRAINT tb_cinema_tb_sessao_fk
FOREIGN KEY (NOME, CNPJ, CPF, FUNCIONARIO_NUM)
REFERENCES TB_CINEMA (NOME, CNPJ, CPF, FUNCIONARIO_NUM)
ON DELETE NO ACTION
ON UPDATE NO ACTION;