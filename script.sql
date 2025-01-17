GO 
CREATE DATABASE RESTAURANTE
GO

USE RESTAURANTE
CREATE TABLE MENU(
	ID_MENU NVARCHAR(10) PRIMARY KEY NOT NULL,
	NOM_MENU VARCHAR(150) NOT NULL,
	DESC_MENU VARCHAR(300) NOT NULL,
	PRECIO FLOAT NOT NULL,
	FOTO VARBINARY(MAX) NOT NULL,
	URL VARCHAR(250)
);

CREATE TABLE CLIENTE(
	ID_CLIENTE NVARCHAR(10) PRIMARY KEY NOT NULL,
	NOM_CLIENTE VARCHAR(150) NOT NULL
);

CREATE TABLE PEDIDO(
	ID_PEDIDO NVARCHAR(10) PRIMARY KEY NOT NULL,
	DESPACHADO INT NOT NULL,
	ID_MENU NVARCHAR(10) NOT NULL,
	ID_CLIENTE NVARCHAR(10)
	FOREIGN KEY (ID_MENU) REFERENCES MENU (ID_MENU),
	FOREIGN KEY (ID_CLIENTE) REFERENCES CLIENTE (ID_CLIENTE)
);

INSERT INTO MENU (ID_MENU, NOM_MENU, DESC_MENU, URL, PRECIO, FOTO) SELECT 1, 'SPAGHETTI', 'SPAGHETTI CON QUESO Y MUCHA SALSA', 'C:\Users\Platos\SPAGHETTI.JPG', 8.00, BulkColumn  FROM Openrowset( 
			Bulk 'C:\Platos\SPAGHETTI.JPG', Single_Blob) as Imagen;

INSERT INTO CLIENTE(ID_CLIENTE, NOM_CLIENTE) VALUES (1, 'JUAN PEREZ');

INSERT INTO PEDIDO(ID_PEDIDO, DESPACHADO, ID_MENU, ID_CLIENTE) VALUES (1, 0, 1, 1);