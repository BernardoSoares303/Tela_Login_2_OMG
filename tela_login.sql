create database tela_login;

use tela_login;

create table usuarios(
	id_usuario int primary key auto_increment,
    nome_usuario varchar(100) unique not null,
    senha_usuario varchar(64) not null
);

select * from usuarios;