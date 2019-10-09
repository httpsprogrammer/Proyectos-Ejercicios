
/*Crea una tabla con un Id */
create table dbo.Estudiante
(
	IdEstudiante int Primary key not null,
	Nombre nvarchar(50) null,
	Edad INT null
);

/*Crea una tabla con un Id */
create table dbo.Curso
(
	IdCurso int Primary key not null,
	NombreCurso nvarchar(20) null,
	NumeroEstudiantes INT null
);

/*Modifico la tabla añadiendo una nueva columna*/
ALTER TABLE dbo.Estudiante ADD 
IdCurso INT NULL 


/*Realizando relación entre las tablas*/
/*Modifico la tabla añadiendo una una clave foranea y que se relacione con la tabla Curso*/
ALTER TABLE dbo.Estudiante ADD CONSTRAINT FK_Estudiante_Curso
FOREIGN KEY(IdCurso) REFERENCES Curso(IdCurso)
GO
