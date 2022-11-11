create table Endereco (
	id_ integer primary key NOT NULL,
	logradouro varchar(256) NOT NULL,
	numero integer NOT NULL,
	cep integer NOT NULL,
	bairro varchar(50) NOT NULL,
	cidade varchar(30) NOT NULL,
	estado varchar(20) NOT NULL
);

create table Telefone_Tipo (
	id_ integer primary key NOT NULL,
	tipo varchar(10) NOT NULL
);

create table Telefone (
	id_ integer primary key NOT NULL,
	numero integer NOT NULL,
	ddd integer NOT NULL,
	tipo integer references Telefone_Tipo (id_) NOT NULL
);

create table Pessoa (
	id_ integer primary key NOT NULL,
	nome varchar(256) NOT NULL,
	cpf bigint NOT NULL,
	Endereco integer references Endereco (id_) NOT NULL
);

create table Pessoa_Telefone (
	id_pessoa integer references Pessoa (id_) primary key NOT NULL,
	id_telefone integer references Telefone (id_) NOT NULL
	
);