create or replace NONEDITIONABLE PACKAGE CLIENTE_PAC
-- CREATE OR REPLACE PACKEGE NOME_PACOTE
IS
-- DECLARAÇÃO DA PROCEDURE QUE SERÁ INCLUIDA NO PACKAGE;
PROCEDURE INCLUIR_CLIENTE 
-- DECLARAÇÃO DA PROCEDURE;
   (p_id in cliente.id%type,
    p_razao_social in cliente.razao_social%type,
    p_CNPJ cliente.CNPJ%type ,
    p_segmercado_id cliente.segmercado_id%type,
    p_faturamento_previsto cliente.faturamento_previsto%type);
    
PROCEDURE INCLUIR_CLIENTE 
-- DECLARAÇÃO DA PROCEDURE COM MENOS PARÂMETROS;
   (p_id in cliente.id%type,
    p_razao_social in cliente.razao_social%type,
    p_segmercado_id cliente.segmercado_id%type);

END;