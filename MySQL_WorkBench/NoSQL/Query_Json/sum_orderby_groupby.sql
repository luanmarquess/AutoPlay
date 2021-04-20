-- somar total salario da tabela mudando o nome da coluna salario para salario total;
SELECT SUM(salario) AS Salario_Total FROM tb_funcionario;

-- json soma
SELECT SUM(JSON_EXTRACT(`JSON`,"$.Salario")) AS Salario_Total from tb_object_funcionario;

-- salario departamento group by MYSQL;
SELECT Numero_Departamento, SUM(Salario) AS Salario_Total_Departamento FROM tb_funcionario
GROUP BY NUMERO_DEPARTAMENTO;

-- salario departamento group by JSON;
SELECT REPLACE (JSON_EXTRACT(`JSON`, "$.Numero_Departamento"),"""","") AS Numero_Departamento, 
SUM(JSON_EXTRACT(`JSON`,"$.Salario")) AS Salario_Total from tb_object_funcionario
GROUP BY REPLACE(JSON_EXTRACT(`JSON`, "$.Numero_Departamento"),"""","")
ORDER BY REPLACE(JSON_EXTRACT(`JSON`, "$.Numero_Departamento"),"""","");

