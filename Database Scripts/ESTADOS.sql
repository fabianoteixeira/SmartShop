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
