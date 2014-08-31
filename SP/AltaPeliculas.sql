USE [VideoClub]
GO
/****** Object:  StoredProcedure [dbo].[AltaPeliculas]    Script Date: 04/26/2013 17:37:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Pablo Taddei
-- Create date: 15/04/2013
-- Description:	Procedimiento Almacenado para guardar una pelicula en el catalogo
-- =============================================
ALTER PROCEDURE [dbo].[AltaPeliculas]
		@titulo varchar(50),
		@genero varchar(50),
		@formato varchar(50),
		@precioAlquiler float,
		@precioCompra float,
		@imagen image,
		@cantidad int,
		@borrada varchar(10)
AS
BEGIN TRY
	INSERT INTO Catalogo
	(
		Titulo,
		Genero,
		Formato,
		PrecioAlquiler,
		PrecioCompra,
		ImagenPelicula, 
		Cantidad,
		Borrada
	)
	VALUES
	(
		@titulo,
		@genero,
		@formato,
		@precioAlquiler,
		@precioCompra,
		@imagen, 
		@cantidad,
		@borrada
	)
END TRY
BEGIN CATCH
	PRINT ERROR_MESSAGE()
END CATCH
