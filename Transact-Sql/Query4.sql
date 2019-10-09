/*'USE' para decir que base de datos voy a usar y realizar operaciones sobre ella*/
USE [PruebaBBDD]

/*Ingresa datos en una tabla*/
INSERT INTO Persona (IdPersona,Nombre,Edad)
VALUES (0,'Pepe',20)
GO

/*Coloca el nombre Ana en columna 'Nombre' de la tabla 'Persona' donde se cumpla la condición*/
UPDATE Persona
SET Nombre = 'Ana'
where IdPersona = 2
GO

/*Coloca el nombre Ana a toda la columna 'Nombre' de la tabla 'Persona'*/
UPDATE Persona
SET Nombre = 'Ana'
GO

/*Elimina todos los registro en donde se cumpla esa condición */
DELETE  FROM Persona
WHERE Nombre = 'Rocio'
GO

/*Elimina todos los registros de una tabla */
DELETE  FROM Persona
GO

/*Selecciona todos los registros de la tabla 'Persona'*/
SELECT * FROM Persona

/*Selecciona los 2 primeros registros de la tabla 'Persona'*/
SELECT Top(2)* FROM Persona


/*Selecciona el registro que cumpla con la restricción*/
SELECT * FROM Persona WHERE IdPersona = 1

/*Selecciona los nombres de todos los registro que cumpla con la restricción*/
SELECT Nombre FROM Persona WHERE Edad = 20
