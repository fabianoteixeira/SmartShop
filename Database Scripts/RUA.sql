create table uf (
	id_uf int not null,
	sigla varchar(50) not null,
	nome varchar(50) not null,

	constraint pk_uf primary key(id_uf)
);


create table cidade(
	id_cidade int not null,
	id_uf int not null,
	nome varchar(100) not null,

	constraint pk_cidade primary key(id_cidade),
	constraint fk_cidade_uf foreign key(id_uf) references uf(id_uf)

);

create table bairro(
	id_bairro int not null,
	id_cidade int not null,
	nome varchar(300) not null,

	constraint pk_bairro primary key(id_bairro),
	constraint fk_bairro_cidade foreign key  (id_cidade) references cidade(id_cidade)
);


create table logradouro (
	id_logradouro int not null,
	id_bairro int not null,
	id_tipo_logradouro int not null,
	nome varchar(100) not null,
	nro_cep_logradouro varchar(20),

	constraint pk_logradouro primary key (id_logradouro),
	constraint fk_logradouro_bairro foreign key (id_bairro) references bairro(id_bairro)

);

create table categoria(
	id_categoria int identity(1,1)  not null,
	descricao varchar(50) not null,
	constraint pk_categoria primary key (id_categoria)
);


create table fornecedor(
	id_fornecedor int identity(1,1) not null,
	id_logradouro int not null,
	nome_fantasia varchar(50),
	cnpj varchar(20),
	inscricao_estadual varchar(20),
	razao_social varchar(50),
	email varchar (40),
	telefone varchar(15),
	observacoes varchar(200),
	
	constraint pk_fornecedor primary key(id_fornecedor),
	constraint fk_fornecedor_logradouro foreign key (id_logradouro) references logradouro(id_logradouro)
	

);


create table fabricante(
	id_fabricante int identity(1,1) not null,
	descricao varchar(50) not null,
	
	constraint pk_fabricante primary key(id_fabricante) 
);


create table produto(
	id_produto int identity(1,1) not null,
	id_fabricante int not null,
	id_categoria int not null,
	descricao varchar(50) not null,
	quantidade int not null,
	imagem_produto varchar(100),
	valor_compra decimal(6,2),
	valor_venda decimal(6,2),
	
	constraint pk_id_produto primary key (id_produto),
	constraint fk_produto_fabricante foreign key (id_fabricante) references fabricante(id_fabricante),
	constraint fk_produto_categoria foreign key(id_categoria) references categoria(id_categoria)
	
);

create table endereco_entrega(
	id_endereco_entrega int identity(1,1) not null,
	id_logradouro int not null
	
	constraint pk_enderece_entrega primary key(id_endereco_entrega),
	constraint fk_endereco_entrega_endereco foreign key(id_logradouro) references logradouro(id_logradouro)
);


create table cliente(
	id_cliente int identity(1,1) not null,
	id_logradouro int not null,
	nome varchar(70) not null,
	cpf varchar (20) not null,
	rg varchar (20) not null,
	data_nascimento date not null,
	sexo char(1),
	telefone varchar(15),
	celular varchar(15),
	data_cadastro date,
	
	constraint pk_cliente primary key(id_cliente),
	constraint fk_cliente_logradouro foreign key(id_logradouro) references logradouro(id_logradouro)
);

create table usuario(
	id_usuario int identity(1,1) not null,
	id_cliente int not null,
	email varchar(50) not null,
	senha varchar(20) not null,
	perfil varchar(30) not null,
	
	constraint pk_usuario primary key(id_usuario),
	constraint fk_usuario_cliente foreign key(id_cliente) references cliente(id_cliente)
);


