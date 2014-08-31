USE [VideoClub]
GO
/****** Object:  StoredProcedure [dbo].[ModCampoBorrada]    Script Date: 04/23/2013 01:17:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		PABLO TADDEI
-- Create date: 23/04/2013
-- Description:	MODIFICACION DEL CAMPO BORRADA.
-- =============================================
ALTER PROCEDURE [dbo].[ModCampoBorrada]
		@titulo varchar(50),
		@borrada varchar(50)
AS
BEGIN TRY
		UPDATE Catalogo SET
		Borrada = @borrada
		WHERE Titulo = @titulo  	
END TRY
BEGIN CATCH
	PRINT ERROR_MESSAGE()
END CATCH
