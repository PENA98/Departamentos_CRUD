USE AdventureWorks2014
GO

CREATE PROCEDURE sp_eliminar_departamento(@nombre varchar(50))
AS
DELETE FROM HumanResources.Department WHERE Name = @nombre
GO