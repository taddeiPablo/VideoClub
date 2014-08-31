USE [VideoClub]
GO
/****** Object:  StoredProcedure [dbo].[ExitePelicula]    Script Date: 04/24/2013 13:07:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		PABLO TADDEI
-- Create date: 22/04/2013
-- Description:	VERIFICAMOS SI EXISTE LA PELICULA Y SI FUE BORRADA DE FORMA LOGICA.
-- =============================================
ALTER PROCEDURE [dbo].[ExitePelicula]
		@Titulo varchar(50),
		@validar varchar(50) OUTPUT
AS
BEGIN TRY
	SET @validar = 'nada'
	IF EXISTS(SELECT * FROM Catalogo WHERE Titulo = @Titulo )
		 SELECT @validar = Borrada FROM Catalogo WHERE Titulo = @Titulo 
		 IF @validar = 'si'
			SELECT @validar
		  ELSE
			SELECT @validar
END TRY
BEGIN CATCH
	PRINT ERROR_MESSAGE()
END CATCH
