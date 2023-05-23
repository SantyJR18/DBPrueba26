--DLL

create database DBPrueba26
go

use DBPrueba26
go

create table Ciudad(
  id INT PRIMARY KEY IDENTITY(1, 1),
  nombre nvarchar(50) not null,
  estado bit default 'true'
);
go

create table Persona(
    id int Primary key identity (1, 1)
	, primerNombre nvarchar(50) NOT NULL
	, segundoNombre nvarchar(50) 
	, primerApellido nvarchar(50) NOT NULL
	, segundoApellido nvarchar(50) 
	, fechaNac dateTime NOT NULL
	, sexo bit default 'true'
	, telefono nvarchar(16) 
	, email nvarchar(100)
	, idCiudad int
	, direccion nvarchar(100) 
	, estado bit default 'true'
);
go 

--DML
--Create/Insertar un registro

Insert into Ciudad(nombre) values(N'Masaya') 
Insert into Ciudad(nombre) values(N'Managua'),(N'Granada'),(N'Rivas'),(N'Leon')


--Read/Mostrar Registro

Select * from Ciudad


--Editar Registros
Update Ciudad set nombre = N'León', estado = 0 where id = 4

Update Ciudad set nombre = N'León', estado = 'true' where id = 4
go

--Delete/Eliminar Registros
delete from Ciudad where id = 5
go

--Create/Insertar registros a la tabla Personas 
Insert into Persona(primerNombre, segundoNombre, primerApellido, segundoApellido, fechaNac, idCiudad) values (N'José', N'Diego', N'Reyes', N'Urbina', '21/03/1990', 1)
go

Insert into Persona(primerNombre, segundoNombre, primerApellido, segundoApellido, fechaNac, idCiudad) values (N'Camilo', N'José', N'Urbina', N'Solís', '21/02/1989', 2)
go

Insert into Persona(primerNombre, segundoNombre, primerApellido, segundoApellido, fechaNac, idCiudad) values (N'Norman', N'Santiago', N'Manzanares', N'Peña', '28/05/2004', 3)
go

--Read/ Mostrar registros
Select * from Persona
go

--Para hacer consultas = ctrl+shift+q
SELECT primerNombre, primerApellido, fechaNac, idCiudad
FROM     Persona

--Esto es una consulta de Persona, donde incluimos el primer nombre, primer apellido y la edad.

SELECT primerNombre+N' '+primerApellido as N'Nombre Completo', year(getdate())-year(fechaNac) as Edad, idCiudad
FROM     Persona

SELECT Persona.primerNombre + N' ' + Persona.segundoNombre + N' ' + Persona.primerApellido + N' ' + Persona.segundoApellido as N'nombrePersona', Ciudad.nombre N'Ciudad', year(getdate()) -  year(Persona.fechaNac) as N'Edad' FROM Persona INNER JOIN Ciudad ON Ciudad.id = Persona.idCiudad