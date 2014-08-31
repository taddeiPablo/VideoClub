USE [VideoClub]
GO
/****** Object:  StoredProcedure [dbo].[AltaPeliculasCompra]    Script Date: 06/16/2013 02:16:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		PABLO TADDEI
-- Create date: 26/04/2013
-- Description:	ALTA DE LA LISTA DE PELICULAS COMPRADAS
-- =============================================
ALTER PROCEDURE [dbo].[AltaPeliculasCompra]
		@IdPelicula int,
		@IdCompra int
AS
BEGIN TRY
	INSERT INTO ListaPeliculasCompras 
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

END CATCH
