-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Pablo Taddei
-- Create date: 14/04/2013
-- Description:	Procedimiento almacenado para hacer altas de clientes
-- =============================================
CREATE PROCEDURE altaClientes 
		
		@nombre varchar(50),
		@apellido varchar(50),
		@dni varchar(50),
		@direccion varchar(50),
		@telefono varchar(50),
		@email varchar(50)
		
AS
BEGIN TRY
	
	INSERT INTO Clientes
	(
		Nombre,
		Apellido,
		Dni,
		Direccion,
		Telefono,
		Email
	)
	VALUES 
	(
		@nombre,
		@apellido,
		@dni,
		@direccion,
		@telefono,
		@email
	)
	
END TRY

BEGIN CATCH

PRINT ERROR_MESSAGE()

END CATCH
GO
