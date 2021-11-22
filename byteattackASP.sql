create database db_ByteAttackASP;
use db_ByteAttackASP;


create table tbUsuario(
	cd_usuario int primary key auto_increment,
    nm_usuario varchar(20) not null,
    ds_senha varchar(10) not null
)default charset utf8;

insert into tbUsuario values(default,'admin','1234567');




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
select * from funcionario;