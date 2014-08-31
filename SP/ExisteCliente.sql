-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		PABLO TADDEI
-- Create date: 21/04/2013
-- Description:	EVALUAMOS SI EXISTE EL CLIENTE ANTES DE REALIZAR EL ALTA
-- =============================================
CREATE PROCEDURE ExisteCliente
		@dni int,
		@valido int OUTPUT
AS
BEGIN TRY
	IF EXISTS ( SELECT dni FROM	Clientes WHERE Dni = @dni)  
        SELECT @valido  = 1
    ELSE
		SELECT @valido = 0 
END TRY
BEGIN CATCH
	PRINT ERROR_MESSAGE()
END CATCH
GO
