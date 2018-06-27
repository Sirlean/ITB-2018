--use master

use LojaJogos_01

go
select 
tb_Cliente.cd_cliente,
tb_Cliente.Nome,
/*tb_Cliente.DtNasc,*/
tb_Cliente.Cpf,
tb_Cliente.Rg,
tb_Cliente.Genero,
tb_Cliente.Endereco,
tb_Cliente.Numero,
tb_Cliente.Complemento,
tb_Cliente.Cidade,
tb_Cliente.Cep,
tb_Cliente.Estado,
tb_Cliente.UF,
tb_Cliente.Email,
tb_Cliente.Telefone,
tb_Cliente.Celular
from tb_Cliente;
go

select * from tb_Cliente;

go

Select 
	tb_TipoProduto.ds_TipoProduto, 
	tb_Produto.Nome, 
	tb_Genero.ds_Genero, 
	tb_FaixaEtaria.ds_FaixaEtaria,
	tb_Fornecedor.NomeFantasia,
	tb_Fabricante.ds_Fabricante
from tb_Produto
	inner join tb_TipoProduto on tb_TipoProduto.Cd_TipoProduto = tb_Produto.cd_TipoProduto and tb_TipoProduto.Ativo = 1
	inner join tb_Genero on tb_Genero.cd_Genero = tb_Produto.cd_Genero and tb_Genero.Ativo = 1
	inner join tb_FaixaEtaria on tb_FaixaEtaria.cd_FaixaEtaria = tb_Produto.cd_FaixaEtaria and tb_FaixaEtaria.Ativo = 1
	inner join tb_Fornecedor on tb_Fornecedor.cd_Fornecedor = tb_Produto.cd_fornecedor and tb_Fornecedor.Ativo = 1
	inner join tb_Fabricante on tb_Fabricante.cd_Fabricante= tb_Produto.cd_Fabricante and tb_Fabricante.Ativo = 1
where 
	tb_Produto.Ativo = 1 and 
	--tb_TipoProduto.ds_TipoProduto like '%jogo%'
	--tb_Produto.cd_Produto = 1
	--tb_Genero.ds_Genero like '%A%'
	--tb_FaixaEtaria.ds_FaixaEtaria like '%%'
	tb_Fornecedor.NomeFantasia like '%t%'
	--tb_Fabricante.ds_Fabricante like '%%'

order by tb_Produto.Nome


go
select * from tb_TipoProduto