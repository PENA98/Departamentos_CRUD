USE AdventureWorks2014
GO

CREATE PROCEDURE sp_insertar_departamento(@nombre varchar(50), @descripcion varchar(50))
AS
INSERT INTO HumanResources.Department (Name, GroupName) Values(@nombre , @descripcion)
GO
