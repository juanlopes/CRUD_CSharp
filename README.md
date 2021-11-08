# CRUD_CSharp_API

First execute this script in MySQL Server

CREATE DATABASE teste_webmotors;

CREATE TABLE teste_webmotors.tb_AnuncioWebmotors (
	ID INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
	marca VARCHAR ( 45 ) NOT NULL,
	modelo VARCHAR ( 45 ) NOT NULL,
	versao VARCHAR ( 45 ) NOT NULL,
	ano INT NOT NULL,
	quilometragem INT NOT NULL,
	observacao text NOT NULL 
)

later, update the database connection info into DataAccessObject.Parametros, so you can start the program successfully.
