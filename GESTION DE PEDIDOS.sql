CREATE DATABASE GESTIONDEPEDIDOS

CREATE TABLE CLIENTE
(
	IDCLIENTE INT IDENTITY (1,1) NOT NULL,
	NOMBRE NVARCHAR (50) NOT NULL,
	APELLIDO NVARCHAR (50) NOT NULL,
	CORREOELECTRONICO NVARCHAR (50) NOT NULL,
	TELEFONO NVARCHAR (50) NOT NULL,
	DIRECCION NVARCHAR (50) NOT NULL,
	PRIMARY KEY (IDCLIENTE),
);

CREATE TABLE PEDIDO
(
	IDPEDIDO INT IDENTITY (1,1) NOT NULL,
	IDCLIENTE INT NOT NULL,
	FECHA DATETIME NOT NULL,
	TOTAL MONEY NOT NULL,
	ESTADO NVARCHAR (50) NOT NULL,
	PRIMARY KEY (IDPEDIDO),
	FOREIGN KEY (IDCLIENTE) REFERENCES CLIENTE (IDCLIENTE)

);

insert into cliente values('Pedro' ,'Fernandez','pedro@gmail.com','+59172979377','Av.Filipinas');
insert into cliente values('Adrián' ,'Pérez' ,'adrian@gmail.com','+59161234567' ,'Barrio las Lomas');
insert into cliente values('Belén','González' ,'belen@gmail.com','+59173456789' ,'Av.Salinas');
insert into cliente values('Ana' ,'Rodríguez' ,'ana@gmail.com','+59169876543' ,'Barrio Constructor');
insert into cliente values('Bruno' ,'López' ,'bruno@gmail.com','+59176213456' ,'La Villa');
insert into cliente values('Carla' ,'García' ,'carla@gmail.com','+59164738291' ,'Debajo Del Puente');

SELECT * FROM CLIENTE

insert into pedido values (1, '2022-02-01 14:00:00', '100', 'En proceso');
insert into pedido values (2, '2022-02-01 13:50:00', '450', 'Pendiente');
insert into pedido values (3, '2022-03-12 09:20:00', '300', 'Pendiente');
insert into pedido values (4, '2022-05-08 18:25:00', '678', 'Completado');
insert into pedido values (5, '2022-05-07 15:30:00', '206', 'Cancelado');
insert into pedido values (6, '2022-06-04 16:45:00', '190', 'Completado');

SELECT * FROM PEDIDO

