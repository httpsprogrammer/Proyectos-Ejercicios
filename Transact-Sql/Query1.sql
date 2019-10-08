/*Crea una base de datos*/
create database PruebaBBDD;

/*'Use' y el nombre de la base de datos que se va a usar*/
Use PruebaBBDD
/*Crea una tabla con un Id */
create table dbo.Persona
(IdPersona int Primary key not null);

/*Elimina una tabla de la base de datos*/
DROP TABLE dbo.Persona; 