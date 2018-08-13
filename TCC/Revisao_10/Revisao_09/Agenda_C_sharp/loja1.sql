---CRIAR BANCO DE DADOS


create dataBase LojaJogo
go
USE LojaJogo;
GO

---CRIAR TABELA

create table tb_produto
(cd_produto int identity (1,1) Primary key,
tipo varchar (100)not null,
nome varchar (100)not null,
genero varchar (100)not null,
faixa_etaria varchar (100)not null,
quantidade int not null,
preco decimal (10,2)not null,
fabricante varchar (100)not null,
plataforma varchar (100)not null,
condicao varchar (100)not null,
fornecedor varchar (100) not null,
Ativo bit default (1) not null
);
go
select * from  tb_produto
go

--drop table  tb_produto

go

insert into tb_produto (tipo,nome,genero,quantidade,preco, fabricante, plataforma, faixa_etaria, condicao, fornecedor)
					
					---Jogos Para PLAYSTATION 4
		values   ( 'JOGOS', 'DRAGON BALL FIGHTERZ EDIÇÃO FIGHTERZ','LUTA VS 3', 20, 174.90,'BANDAI NAMCO','PLAYSTATION 4','12 ANOS','NOVO','SONY'),
		         ( 'JOGOS', 'FAR CRY 5 STEELBOOK','AÇÃO/AVENTURA', 10, 249.90,'UBISOFT','PLAYSTATION 4','18 ANOS', 'NOVO','SONY' ),
				 ( 'JOGOS', 'MONSTE ENERGY SUPERCROSS','CORRIDA', 10, 199.90,'SQUARE ENIX','PLAYSTATION 4','LIVRE','NOVO','SONY' ),

					---Jogos Para PLAYSTATION 3
				 ( 'JOGOS', 'JUST DANCE 2018 PTBR CPP (NAC-BRA) PS3 UBI','DANÇA', 10, 199.90, 'UBISOFT','PLAYSTATION 3','LIVRE','NOVO','SONY' ),
				 ( 'JOGOS', 'FIFA 2018','DANÇA', 15, 129.90, 'EA GAMES','PLAYSTATION 3','LIVRE','NOVO','SONY' ),
				 ( 'JOGOS', 'DRAGON BALL z - BATTLE OF Z','LUTA', 25, 159.90, 'BANDAI NAMCO','PLAYSTATION 3','10 ANOS','NOVO','SONY' ),

				   ---Consoles PLAYSTATION 4
				 ( 'CONSOLE', 'CONSOLE PS4 500GB SLIM + UNCHARTED','OUTROS', 10, 1599.90, 'SONY','PLAYSTATION 4','LIVRE','NOVO','SONY' ),
				 

				 ---Controle  PLAYSTATION 3
				 ('CONSOLE','PLAYSTATION 3 + SUPER SLIM','OUTROS',15,650.00,'SONY','PLAYSTATION 3','LIVRE','USADO','SONY'),

				 ---Consoles XBOX
				('CONSOLE','CONSOLE XONE 1TB BRANCO + ASSASSINS CREED ORIGINS + TOM CLANCYS','OUTROS', 15, 1799.90, 'MICROSOFT','XBOX ONE','LIVRE','NOVO','MICROSOFT' ),
			    ('CONSOLE','XBOX ONE X 1TB','OUTROS',13, 2799.90,'MICROSOFT','XBOX ONE','LIVRE','NOVO','MICROSOFT'),
				

				---controle
				
				---(tipo,nome,genero,quantidade,preco, fabricante, plataforma, faixa_etaria, condicao, fornecedor)
					('CONTROLE','CONTROLE PS4 SEM FIO DUALSHOCK CAMUFLADO SONY','OUTROS',12,279.90,'SONY','PLAYSTATION 4','LIVRE','NOVO','SONY'),
					('CONTROLE','CONTROLE PS4 SEM FIO DUALSHOCK BLACK SONY','OUTROS',24,259.90,'SONY','PLAYSTATION 4','LIVRE','NOVO','SONY'),
					('CONTROLE','CONTROLE PS3 FEIR S/ FIO','OUTROS',12,129.90,'FEIR','PLAYSTATION 3','LIVRE','NOVO','SONY'),
					
				
				---headset
				('HEADSET','HEADSET SONY WIRELESS STEREO GOLD - PS4, PS3 E PS VITA','OUTROS',25, 599.90,'SONY','PS4, PS3 E PS VITA','LIVRE','NOVO','SONY'),
				('HEADSET','HEADSET GAMER FEIR PC/PS4/PS3','OUTROS',15, 110.90,' FEIR','PC/PS4/PS3','LIVRE','NOVO','FEIR'),
				('HEADSET','HEADSET GAMES G230 DGTL PC','OUTROS',10, 199.90,'LOGITECH','PC','LIVRE','NOVO','SOFTRONIC');




go

create table tb_Cliente
(cd_cliente int identity (1,1) primary key,
Nome varchar (200) not null,
DtNasc Date not null,
Cpf varchar (20) not null,
Rg char (20) null,
Genero char (1) not null,
Endereco varchar (100) not null,
Numero char (4) not null,
Complemento varchar(100)null,
Cidade varchar (100) not null,
Cep char (8) not null,
Estado varchar (100)not null,
UF char(2) not null,
Email varchar (100) not null,
Telefone varchar (11) not null,
Celular varchar (15)not null

);
go 
select*from  tb_cliente
go



insert into tb_cliente (Nome, DtNasc,Cpf, Rg, Genero, Endereco, Numero,Complemento, Cidade, Cep, Estado, UF, Email, telefone, Celular)
	
	---clientes cadastrados
	values	('Lucas Santos', '1986-09-02','011.000.222-52', '12345-3','M','Rua Guimaraes Rosa', 07,'casaA', 'Barueri','06435000', 'São Paulo', 'SP', 'lucas@gmail.com',41255595, 994993256, 'S'),
			('Alberto Souza','1986-12-02', '01.222.333-67', '235412-5','M', 'Via Carijo', 13,'casaC','Barueri', '06453200', 'São Paulo', 'SP', 'alberto@hotmail.com',41948855,  72628558, 'S'),
			('Guilherme Matias','1986-09-30', '002.336.212-25','123564-9','M','Rua Mathias', 01,'BLA', 'Jandira', '06352000', 'São Paulo', 'SP', 'guilherme@gmail.com', 42154254,  74853214,'N'),
			('Felipe Santiago', '1986-09-21','002.336.212-23','129064-9','M','Rua Antonio', 01, 'casaL','Osasco', '06352000', 'São Paulo', 'SP', 'felipe@gmail.com', 35154254,  74853213,'N');


			----drop table  tb_cliente

go

create table tb_funcionario
(cd_func int identity (1,1) primary key,


Nome varchar (100) not null,
Cargo varchar(200)not null,
DtNasc date not null,
Cpf varchar (11) not null,
rg char (15) not null,
genero char (1) not null,
endereco varchar (100) not null,
cep char (8) not null,
numero char (4) not null,
estado char(2)not null,
cidade varchar(100)not null,
telefone varchar (11) not null,
cecular varchar (15)not null,
email varchar (100)not null,
data_adm char(10)not null,
data_demicional char(10)not null,
);
go 
select*from  tb_funcionario
go











				
/////-----------------excluir só teste-----------------------------------------

create table  t_dadosAgenda
(cd_dadosAgenda int identity (1,1) Primary key,
novo varchar (100)not null,
consultar varchar (100)not null,
alterar varchar (100)not null,
excluir varchar (100)not null,

);
go
select * from   t_dadosAgenda
go

insert into t_dadosAgenda (novo,consultar,alterar,excluir)
					
					---Jogos Para PLAYSTATION 4
		values   ( 'JOGOS', 'DRAGON BALL FIGHTERZ EDIÇÃO FIGHTERZ','LUTA VS 3', 20);

	drop table t_dadosAgenda

	/////-----------------excluir só teste-----------------------------------------

create table  BuscaProduto
(cd_BuscaProduto int identity (1,1) Primary key,
tipo varchar (100)not null,
nome varchar (100)not null,
genero varchar (100)not null,
faixaEtaria varchar (100)not null,

);
go
select * from   BuscaProduto
go

insert into BuscaProduto (tipo,nome,genero,faixaEtaria)
					
					---Jogos Para PLAYSTATION 4
		values   ( 'JOGOS', 'DRAGON BALL FIGHTERZ EDIÇÃO FIGHTERZ','LUTA VS 3', 20),
				( 'JOGOS', 'FAR CRY 5 STEELBOOK','AÇÃO/AVENTURA', 10 ),
				( 'JOGOS', 'MONSTE ENERGY SUPERCROSS','CORRIDA', 10 ),

						---Jogos Para PLAYSTATION 3
				 ( 'JOGOS', 'JUST DANCE 2018 PTBR CPP (NAC-BRA) PS3 UBI','DANÇA', 10 ),
				 ( 'JOGOS', 'FIFA 2018','DANÇA', 15 ),
				 ( 'JOGOS', 'DRAGON BALL z - BATTLE OF Z','LUTA', 25),

				   ---Consoles PLAYSTATION 4
				 ( 'CONSOLE', 'CONSOLE PS4 500GB SLIM + UNCHARTED','OUTROS', 10 ),
				 ( 'CONSOLE', 'CONSOLE PS4 500GB SLIM + UNCHARTED','OUTROS',10),

				 ---Controle  PLAYSTATION 3
				 ('CONSOLE','PLAYSTATION 3 + SUPER SLIM','OUTROS',15),

			

				---controle
				
				---(tipo,nome,genero,quantidade,preco, fabricante, plataforma, faixa_etaria, condicao, fornecedor)
					('CONTROLE','CONTROLE PS4 SEM FIO DUALSHOCK CAMUFLADO SONY','OUTROS',12),
					('CONTROLE','CONTROLE PS4 SEM FIO DUALSHOCK BLACK SONY','OUTROS',24),
					('CONTROLE','CONTROLE PS3 FEIR S/ FIO','OUTROS',12),
					('CONTROLE','CONTROLE PS3 FEIR S/ FIO','OUTROS',12),
				
				---headset
				('HEADSET','HEADSET SONY WIRELESS STEREO GOLD - PS4, PS3 E PS VITA','OUTROS',25),
				('HEADSET','HEADSET GAMER FEIR PC/PS4/PS3','OUTROS',15),
				('HEADSET','HEADSET GAMES G230 DGTL PC','OUTROS',10);

				drop table BuscaProduto


	/////-----------------excluir só teste-----------------------------------------

create table  BuscarCliente
(cd_BuscarCliente int identity (1,1) Primary key,
NOME varchar (100)not null,
CPF varchar (100)not null,
RG varchar (100)not null,
GENERO varchar (100)not null,

);
go
select * from   BuscarCliente
go

insert into BuscarCliente (NOME,CPF,RG,GENERO)
					
	values	('Lucas Santos', '011.000.222-52', 12345-3,'M'),
			('Alberto Souza', '01.222.333-67', 235412-5,'M'),
			('Guilherme Matias', '002.336.212-25',123564-9,'M'),
			('Felipe Santiago', '002.336.212-23',129064-9,'M');


			drop table  BuscarCliente 

	