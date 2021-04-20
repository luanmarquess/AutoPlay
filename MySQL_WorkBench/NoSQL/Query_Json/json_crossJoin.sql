SELECT `JSON` FROM T1;

SELECT JSON_EXTRACT(`JSON`, "$.Cliente") FROM t1;

-- tranformar o conteudo do json em tabela
SELECT * FROM T1
CROSS JOIN 
JSON_TABLE (JSON_EXTRACT(`JSON`, "$.Cliente"), "$[*]"
COLUMNS (NOME VARCHAR(10) PATH "$.Nome", HOBBY VARCHAR(10) PATH "$.Hobby")) T2;

-- exibe apenas o nome e hobby da tabela transformada do conteudo do json;
-- cross join = join que nao utiliza condicao para juntar duas tabelas;
-- "$[*]" = requisita todos os campos dentro dos elementos do array;
-- json table = nao e uma tabela, apenas tem o comportamento dela;
-- JSON_TABLE (JSON_EXTRACT(`JSON`, "$.Cliente") = elemento a transformar em tabela;
-- columns = expecifica os atributos das colunas;
-- path = busca a propriedade do elemento do array 
SELECT t2.Nome, t2.Hobby FROM T1
CROSS JOIN 
JSON_TABLE (JSON_EXTRACT(`JSON`, "$.Cliente"), "$[*]"
COLUMNS (NOME VARCHAR(10) PATH "$.Nome", HOBBY VARCHAR(10) PATH "$.Hobby")) T2;