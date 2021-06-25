-- criou tabela do tipo json
CREATE TABLE t1 (`JSON` json);

-- inseriu classe de atributos para hobby 
INSERT INTO t1 VALUES ('{"Hobby": ["Praia", "Futebol", "Volei"]}');

-- select da tabela t1
SELECT `JSON` FROM t1;

-- select no array isolado
SELECT JSON_EXTRACT(`JSON`,"$.Hobby") AS Hobby FROM t1;

-- busca o elemento pelo indice;
SELECT JSON_EXTRACT(`JSON`,"$.Hobby[0]") AS Hobby FROM t1;
SELECT JSON_EXTRACT(`JSON`,"$.Hobby[1]") AS Hobby FROM t1;
SELECT JSON_EXTRACT(`JSON`,"$.Hobby[2]") AS Hobby FROM t1;

-- excluir tabela
DROP TABLE t1;

-- criou tabela do tipo json
CREATE TABLE t1 (`JSON` json);

-- inserir json na table 
INSERT INTO t1 VALUES ('');
INSERT INTO t1 VALUES ('{
  "Cliente": [
    {
      "Nome": "Joao",
      "Hobby": [
        "Praia",
        "Futebol",
        "Volei"
      ]
    },
    {
      "Nome": "Carlos",
      "Hobby": [
        "Cinema",
        "Luta"
      ]
    }
  ]
}');

SELECT `JSON` FROM T1;

-- select no json com mais de uma classe
SELECT JSON_EXTRACT(`JSON`,"$.Cliente") FROM T1;

-- select de elemento expecifico
SELECT JSON_EXTRACT(`JSON`,"$.Cliente[0].Nome") FROM T1;
SELECT JSON_EXTRACT(`JSON`,"$.Cliente[1].Nome") FROM T1;

SELECT JSON_EXTRACT(`JSON`,"$.Cliente[0].Hobby[0]") FROM T1;
SELECT JSON_EXTRACT(`JSON`,"$.Cliente[0].Hobby[1]") FROM T1;



-- excluir tabela
DROP TABLE t1;

-- criou tabela do tipo json
CREATE TABLE t1 (`JSON` json);

INSERT INTO t1 VALUES ('{
  "Cliente": [
    {
      "Nome": "Joao",
      "Hobby": "Praia"
    },
    {
      "Nome": "Carlos",
      "Hobby": "Cinema"
    }
  ]
}');

-- select elemento Cliente indice 0, propriedade Nome so, mudando o nome da coluna para "nome";
SELECT JSON_EXTRACT(`JSON`,"$.Cliente[0].Nome") AS NOME FROM T1;

-- select elemento Cliente indice 0, propriedade Nome e Hobby, mudando seus nomes de coluna;
SELECT JSON_EXTRACT(`JSON`,"$.Cliente[0].Nome") AS NOME, JSON_EXTRACT(`JSON`,"$.Cliente[0].Hobby") AS Hobby FROM T1;

-- Union 
SELECT JSON_EXTRACT(`JSON`,"$.Cliente[0].Nome") AS NOME, JSON_EXTRACT(`JSON`,"$.Cliente[0].Hobby") AS Hobby FROM T1
UNION
SELECT JSON_EXTRACT(`JSON`,"$.Cliente[1].Nome") AS NOME, JSON_EXTRACT(`JSON`,"$.Cliente[1].Hobby") AS Hobby FROM T1





