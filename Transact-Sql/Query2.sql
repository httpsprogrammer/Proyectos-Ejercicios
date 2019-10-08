/*ADD (añade), ALTER (modifica), DROP (elimina), COLUMN (columna), CONSTRAINT (restricción)*/

/*'ALTER TABLE' Sirve para modificar una tabla ya existente*/
/*Permite nulos*/
ALTER TABLE dbo.Persona ADD Nombre VARCHAR(20) NULL, Edad INT NULL ;

/*'ALTER TABLE' Sirve para modificar una tabla ya existente*/
/*'ADD' sirve para añadir una columna*/
ALTER TABLE dbo.Persona ADD Email VARCHAR(50) NULL
GO

/*'ALTER TABLE' Sirve para modificar una tabla ya existente*/
/*'DROP' sirve para eliminar una columna*/
ALTER TABLE dbo.Persona DROP Column Email 
