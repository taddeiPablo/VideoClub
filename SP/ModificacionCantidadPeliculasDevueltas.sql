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
-- Author:		pablo taddei
-- Create date: 21/06/2013
-- Description:	MODIFICACION DE EL CATALOGO PARA CUANDO SE DEVUELVE UNA PELICULA
-- LUEGO DE UN ALQUILER
-- =============================================
CREATE PROCEDURE ModificacionCantidadPeliculasDevueltas
	@idPelicula int,
	@cant int
AS
BEGIN TRY
	SELECT @cant = cantidad FROM Catalogo WHERE IdPelicula = @idPelicula 
	UPDATE Catalogo SET Cantidad = @cant + 1 WHERE IdPelicula = @idPelicula 
END TRY
BEGIN CATCH
	PRINT ERROR_MESSAGE()
END CATCH
