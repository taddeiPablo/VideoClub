USE [VideoClub]
GO
/****** Object:  StoredProcedure [dbo].[CargarDatosPeliculas]    Script Date: 04/26/2013 18:18:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		PABLO TADDEI
-- Create date: 20/04/2013
-- Description:	SP PARA TRAERNOS TODAS LAS PELICULAS DEL CATALOGO
-- =============================================
ALTER PROCEDURE [dbo].[CargarDatosPeliculas] 
	--NO RESIBE PARAMETROS
AS
BEGIN TRY
	SELECT IdPelicula, Titulo,Genero,Formato,PrecioAlquiler,PrecioCompra,ImagenPelicula,Cantidad  FROM Catalogo WHERE Borrada != 'si' 
END TRY
BEGIN CATCH
	PRINT ERROR_MESSAGE()
END CATCH
