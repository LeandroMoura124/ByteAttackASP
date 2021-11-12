create database db_ByteAttackASP;
use db_ByteAttackASP;


create table tbUsuario(
	cd_usuario int primary key auto_increment,
    nm_usuario varchar(20) not null,
    ds_senha varchar(10) not null
)default charset utf8;

insert into tbUsuario values(default,'admin','1234567');