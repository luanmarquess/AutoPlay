SET SERVEROUTPUT ON;
-- autoriza a exibi��o na �rea do script output;

DECLARE
v_ID NUMBER (5) := 1;
--NOME VARI�VEL, TIPO, TAMANHO; := RECEBE;

BEGIN
v_ID := 2;
-- vari�vel v_ID recebe 2.
dbms_output.put_line(v_ID);

END;
