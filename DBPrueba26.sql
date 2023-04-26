--DDL
/*Crear bd*/

create database DBPrueba26;
go

use DBPrueba26
go

create table Ciudad (
	id INT IDENTITY(1,1) PRIMARY KEY,
	nombre VARCHAR(30) NOT NULL,
	estado BIT DEFAULT 'true'
);
go

CREATE TABLE Persona (
    id INT IDENTITY(1,1) PRIMARY KEY,
    primerNombre VARCHAR(50) NOT NULL,
	segundoNomnre VARCHAR(50) NULL,
    primerApellido VARCHAR(50) NOT NULL,
	segundoApellido VARCHAR(50) NULL,
    fecha_nacimiento DATETIME NOT NULL,
    sexo BIT DEFAULT 1 NOT NULL,
    email VARCHAR(100) UNIQUE,
    telefono VARCHAR(20),
    direccion VARCHAR(100),
	estado BIT DEFAULT 'true'
);
go

--DML

-- Create/Insertar un registro

Insert into Ciudad(nombre) values (N'Masaya')
Insert into Ciudad(nombre) values (N'Managua'), (N'Granada'), (N'Jinotepe'), (N'Leon')

--Mostrar registro

SELECT * FROM Ciudad
go