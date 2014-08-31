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
-- Author:		PABLO TADDEI
-- Create date: 24/04/2013
-- Description:	ALTA DE PELICULAS DEL ALQUILER
-- =============================================
CREATE PROCEDURE altaPeliculasAlquiler
		@idAlquiler int,
		@idCompra int,
		@idPelicula int
AS
BEGIN TRY
	INSERT INTO ListadodelCliente
	(
		IdAlquiler,
		IdCompra,
		IdPelicula
	)
	VALUES
	(
		@idAlquiler,
		@idCompra,
		@idPelicula
	)
END TRY
BEGIN CATCH
	PRINT ERROR_MESSAGE()
END CATCH
GO
