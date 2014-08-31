USE [VideoClub]
GO
/****** Object:  StoredProcedure [dbo].[DatosCompras]    Script Date: 04/28/2013 06:53:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		PABLO TADDEI
-- Create date: 24/04/2013
-- Description:	SP PARA TREAR TODAS LAS COMPRAS DEL CLIENTE A PARTIR DEL ID
-- =============================================
ALTER PROCEDURE [dbo].[DatosCompras]
		@idCliente int
AS
BEGIN TRY
	SELECT Catalogo.Titulo,Catalogo.Genero,Catalogo.Formato,Catalogo.ImagenPelicula ,Compras.TotalCompra,Compras.TipodePago FROM Catalogo INNER JOIN ListaPeliculasCompras  ON Catalogo.idPelicula = ListaPeliculasCompras.IdPelicula 
	INNER JOIN Compras ON ListaPeliculasCompras.IdCompra  = Compras.idCompra WHERE Compras.IdCliente = @idCliente 
END TRY
BEGIN CATCH
	PRINT ERROR_MESSAGE()
END CATCH
