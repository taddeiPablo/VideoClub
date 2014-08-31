USE [VideoClub]
GO
/****** Object:  StoredProcedure [dbo].[CargarDatos]    Script Date: 04/21/2013 03:01:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Pablo Taddei
-- Create date: 20/04/2013
-- Description:	SP PARA TRAERNOS TODOS LOS CLIENTES.
-- =============================================
ALTER PROCEDURE [dbo].[CargarDatos]
	--no resive ningun parametro	
AS
BEGIN TRY
	SELECT IdCliente, Nombre,Apellido,Dni,Direccion,Telefono,Email FROM Clientes
END TRY
BEGIN CATCH
	PRINT ERROR_MESSAGE()
END CATCH
