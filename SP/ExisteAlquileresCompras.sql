USE [VideoClub]
GO
/****** Object:  StoredProcedure [dbo].[ExisteAlquileresCompras]    Script Date: 04/26/2013 11:15:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		PABLO TADDEI
-- Create date: 22/04/2013
-- Description:	VERIFICAMOS ANTES DE BORRAR AL CLIENTE SI TIENE ALQUILERES Y COMPRAS
-- =============================================
ALTER PROCEDURE [dbo].[ExisteAlquileresCompras]
		@idCliente int,
		@verificar int OUTPUT
AS
BEGIN TRY
	IF EXISTS (SELECT * FROM Alquileres WHERE IdCliente = @idCliente)OR EXISTS(SELECT * FROM Compras WHERE IdCliente = @idCliente)  
        SELECT @verificar = 1
    ELSE
		SELECT @verificar = 0 
END TRY
BEGIN CATCH
	PRINT ERROR_MESSAGE()
END CATCH
