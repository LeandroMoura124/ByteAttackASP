create database db_ByteAttackASP;
use db_ByteAttackASP;


create table tbUsuario(
	cd_usuario int primary key auto_increment,
    nm_usuario varchar(20) not null,
    ds_senha varchar(10) not null
)default charset utf8;

insert into tbUsuario values(default,'admin','1234567');
insert into tbUsuario values(default,'Leandro admin','1234567');




create table funcionario(
IDfunc int not null,
nomeFunc varchar(40) not null,
cpf bigint(14) not null,
rg bigint(14) not null,
nascimento date not null,
endereco varchar(100) not null,
cel varchar(11) not null,
email varchar(40) not null, 
cargo varchar(30) not null,
Primary key (IDfunc, cpf)

) DEFAULT CHARSET = utf8;



create table cliente(
nomeCliente varchar(40) not null,
cpf bigint(14) not null,
nascimento date not null,
email varchar(40) not null,
cel varchar(11) not null,
enderecocli varchar(100) not null,
primary key(cpf)

)DEFAULT CHARSET = utf8;


CREATE TABLE Procedimento (
IDProcedimento int PRIMARY KEY,
NomeProcedimento varchar(40) not null,
DataProcedimento datetime not null,
DescProcedimento mediumtext not null,
MetodoPgto varchar(20) not null,
ValorTotal varchar(15) not null
)DEFAULT CHARSET = utf8;

CREATE TABLE Especialista (
NomeEspec varchar(40) not null,
DataNascEspec datetime not null,
cpfEspec bigint(14) not null,
EmailEspec varchar(40) not null,
NumEspec varchar(11) not null,
IDEspecialista int not null,
Primary Key (cpfEspec, IDEspecialista)
)DEFAULT CHARSET = utf8;




select * from funcionario;
select * from cliente;
truncate cliente;
truncate funcionario;
truncate procedimento;
truncate especialista;


insert into Especialista values('Vitor Ribeiro Augusto', '2004-10-11', '49931503858', 'leokurt4@gmail.com', '11985803670', '1');



select * from procedimento;


 