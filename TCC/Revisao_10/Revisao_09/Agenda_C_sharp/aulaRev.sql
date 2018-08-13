-- Transaction: Usado para controlar as execucoes de transacoes apos a definição do BEGIN TRAN [nome_para_minha_transacao];
-- Transacoes sao as linhas que geram alterações dentro do banco de dados (ex. insert, delete e update)
BEGIN TRAN TESTE_sirlean;

SELECT * FROM tb_Fornecedor;

DELETE FROM tb_Fornecedor where cd_Fornecedor = 3;
DELETE FROM tb_Fornecedor where cd_Fornecedor = 4;
DELETE FROM tb_Fornecedor where cd_Fornecedor = 5;
update tb_Fornecedor set Cnpj ='11111111111' where cd_fornecedor = 1;

SELECT * FROM tb_Fornecedor;

--COMMIT TRAN: usado para efetivar as transações ocorridas após a definição do BEGIN TRAN
---commit tran TESTE_sirlean
--ROLLBACK TRAN: usado para desfazer as transações ocorridas após a definição do BEGIN TRAN 

ROLLBACK TRAN TESTE_sirlean;

SELECT * FROM tb_Fornecedor;

update tb_Fornecedor set Ativo = 1