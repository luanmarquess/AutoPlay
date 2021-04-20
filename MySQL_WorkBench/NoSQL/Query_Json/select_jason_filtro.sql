
-- continuação última aula
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

-- filtro JASON_EXTRACT(`JASON`,'$.CONDICAO') = ALGUMA COISA
SELECT * FROM tb_object_funcionario WHERE JSON_EXTRACT(`JSON`,'$.Sexo') = "F";

-- exemplo filtro
SELECT*FROM tb_object_funcionario WHERE JSON_EXTRACT(`JSON`,'$.Data_Nascimento')>= '1980-01-01';

-- exemplo year
SELECT*FROM tb_object_funcionario WHERE YEAR (JSON_EXTRACT(`JSON`,'$.Data_Nascimento'))>= '1980'
-- Replace(JASON_EXTRACT(`JSON`,"$.ATRIBUTO") AS MUDAR_NOME_ATRIBUTO, WHERE JSON_EXTRACT(`JSON`,"$.ATRIBUTO_CONDICAO") = OU > OU TRUE OU FALSE...
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
FROM tb_object_funcionario
WHERE YEAR (JSON_EXTRACT(`JSON`, "$.Data_Nascimento"))>= 1980 
AND JSON_EXTRACT(`JSON`,'$.Sexo') = 'M' 
AND JSON_EXTRACT(`JSON`,'$.Salario') >= 19000;

-- exercicio modulo 2;
SELECT JSON_EXTRACT(JSONVALUE, "$.Nome_Departamento") FROM tb_object_departamento
WHERE YEAR (JSON_EXTRACT(JSONVALUE,"$.Data_Inicio_Gerente")) = 2005;