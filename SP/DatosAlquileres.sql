USE [VideoClub]
GO
/****** Object:  StoredProcedure [dbo].[DatosAlquileres]    Script Date: 04/28/2013 06:50:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		PABLO TADDEI
-- Create date: 24/04/2013
-- Description:	SP PARA TRAERNOS TODOS LOS ALQUILERES SEGUN EL ID DEL CLIENTE
-- =============================================
ALTER PROCEDURE [dbo].[DatosAlquileres]
		@idCliente int
AS
BEGIN TRY
	SELECT Catalogo.Titulo,Catalogo.Genero,Catalogo.Formato,Catalogo.ImagenPelicula,Alquileres.TotalAlquiler,Alquileres.TipodePago,Alquileres.FechaInicio,Alquileres.FechaFinal  FROM Catalogo INNER JOIN ListaPeliculasAlquiladas  ON Catalogo.idPelicula = ListaPeliculasAlquiladas.IdPelicula 
	INNER JOIN Alquileres ON ListaPeliculasAlquiladas.IdAlquiler = Alquileres.idAlquiler WHERE Alquileres.IdCliente = @idCliente 
END TRY
BEGIN CATCH
	PRINT ERROR_MESSAGE()
END CATCH
