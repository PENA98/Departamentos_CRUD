USE AdventureWorks2014
GO

CREATE PROCEDURE sp_actualizar_departamento(@nombre varchar(50), @descripcion varchar(50))
AS
UPDATE HumanResources.Department SET GroupName = @descripcion where Name = @nombre
GO