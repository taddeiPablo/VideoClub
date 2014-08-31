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
-- Create date: 22/04/2013
-- Description:	SP PARA BORRAR UNICAMENTE A UN CLIENTE QUE TODABIA NO HAYA TENIDO NI ALQUILERES NI COMPRAS
-- =============================================
CREATE PROCEDURE BorrarClienteUnicamente
		@idCliente int
AS
BEGIN TRY
		DELETE FROM Clientes WHERE IdCliente = @idCliente 
END TRY
BEGIN CATCH
		PRINT ERROR_MESSAGE()
END CATCH
GO
