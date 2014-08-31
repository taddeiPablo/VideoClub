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
-- Description:	SP PARA GUARDAR LA LISTA DE PELICULAS COMPRADAS
-- =============================================
CREATE PROCEDURE guardarCompras
		@idPelicula int,
		@IdCompra int
AS
BEGIN TRY
	INSERT INTO ListadodelCliente 
	(
		IdPelicula,
		IdCompra
	)
	VALUES
	(
		@idPelicula,
		@IdCompra 
	)
END TRY
BEGIN CATCH
	PRINT ERROR_MESSAGE()
END CATCH
GO
