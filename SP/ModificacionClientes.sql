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
-- Create date: 15/04/2013
-- Description:	Procedimiento almacenado para modificar a un cliente
-- =============================================
CREATE PROCEDURE ModificarCliente
		@idcliente int,
		@nombre varchar(50),
		@apellido varchar(50),
		@dni varchar(50),
		@direccion varchar(50),
		@telefono varchar(50),
		@email varchar(50)
AS
BEGIN TRY
	UPDATE Clientes SET 
		Nombre = @nombre, 	
		Apellido = @apellido, 
		Dni = @dni, 
		Direccion = @direccion, 
		Telefono = @telefono, 
		Email = @email 
		WHERE IdCliente = @idcliente
END TRY
BEGIN CATCH
	PRINT ERROR_MESSAGE()
END CATCH
GO
