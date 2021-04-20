SELECT * FROM tb_funcionario;

-- select de um bloco json
SELECT `JSON` AS TB_JSON_DOCUMENTO FROM tb_object_funcionario;

-- select de um bloco json ja identado ao copiar e colocar no interpretador
SELECT JSON_PRETTY(`JSON`) AS TB_JSON_DOCUMENTO FROM tb_object_funcionario;

-- aplica filtro no json, exibindo apenas o campo sexo da tabela
SELECT `JSON` -> "$.Sexo"  AS SEXO FROM tb_object_funcionario;

-- tira "" do conteudo da coluna sexo
SELECT REPLACE(`JSON` -> "$.Sexo","""","")  AS SEXO FROM tb_object_funcionario;

-- mesmo resultado do filtro anterior
SELECT REPLACE(JSON_EXTRACT(`JSON`,"$.Sexo"),"""","") AS SEXO FROM tb_object_funcionario;

-- extrair propriedades dividindo em colunas
SELECT
REPLACE(JSON_EXTRACT(`JSON`,"$.Cpf"),"""","") AS CPF,
REPLACE(JSON_EXTRACT(`JSON`,"$.Data_Nascimento"),"""","") AS DATA_NASCIMENTO,
REPLACE(JSON_EXTRACT(`JSON`,"$.Primeiro_Nome"),"""","") AS PRIMEIRO_NOME,
REPLACE(JSON_EXTRACT(`JSON`,"$.Nome_Meio"),"""","") AS NOME_MEIO,
REPLACE(JSON_EXTRACT(`JSON`,"$.Ultimo_Nome"),"""","") AS ULTIMO_NOME,
REPLACE(JSON_EXTRACT(`JSON`,"$.Endereco"),"""","") AS ENDERECO,
REPLACE(JSON_EXTRACT(`JSON`,"$.Salario"),"""","") AS SALARIO,
REPLACE(JSON_EXTRACT(`JSON`,"$.Sexo"),"""","") AS SEXO,
REPLACE(JSON_EXTRACT(`JSON`,"$.Cpf_Supervisor"),"""","") AS CPF_SUPERVISOR,
REPLACE(JSON_EXTRACT(`JSON`,"$.Numero_Departamento"),"""","") AS NUMERO_DEPARTAMENTO,
REPLACE(JSON_EXTRACT(`JSON`,"$.Dependentes"),"""","") AS DEPENDENTES
FROM tb_object_funcionario;



