SET SERVEROUTPUT ON;
-- autoriza a exibição na área do script output;

DECLARE
v_ID NUMBER (5) := 1;
--NOME VARIÁVEL, TIPO, TAMANHO; := RECEBE;

BEGIN
v_ID := 2;
-- variável v_ID recebe 2.
dbms_output.put_line(v_ID);

END;
