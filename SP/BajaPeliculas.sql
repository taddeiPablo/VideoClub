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
-- Description:	Procedimiento Almacenado para borrar una pelicula del catalogo.
-- =============================================
CREATE PROCEDURE BorrarPelicula
		@idPelicula int,
		@borrado varchar(10)
AS
BEGIN TRY
	UPDATE Catalogo SET
	Borrada = @borrado
	WHERE 
	IdPelicula = @idPelicula
END TRY
BEGIN CATCH
	PRINT ERROR_MESSAGE()
END CATCH
GO
