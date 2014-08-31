USE [VideoClub]
GO
/****** Object:  StoredProcedure [dbo].[ModificacionPelicula]    Script Date: 06/23/2013 06:21:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Batch submitted through debugger: SQLQuery8.sql|7|0|C:\Users\pablo\AppData\Local\Temp\~vsB9A7.sql
-- =============================================
-- Author:		Pablo Taddei
-- Create date: 15/04/2013
-- Description:	Procedimiento Almacenado para modificar una pelicula
-- =============================================
ALTER PROCEDURE [dbo].[ModificacionPelicula]
		@idPelicula int,
		@titulo varchar(50),
		@genero varchar(50),
		@formato varchar(50),
		@precioAlquiler float,
		@imagen image,
		@precioCompra float,
		@cantidad int,
		@borrada varchar(10)
AS
BEGIN TRY
	UPDATE Catalogo SET
	Titulo = @titulo,
	Genero = @genero,
	Formato = @formato,
	PrecioAlquiler = @precioAlquiler,
	PrecioCompra = @precioCompra,
	ImagenPelicula = @imagen,
	Cantidad = @cantidad,
	Borrada = @borrada 
	WHERE 
	IdPelicula = @idPelicula
END TRY
BEGIN CATCH
	PRINT ERROR_MESSAGE()
END CATCH
