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
-- Create date: 24/05/2013
-- Description:	SP PARA GUARDAR ALQUILER
-- =============================================
CREATE PROCEDURE guardarAlquiler
		@tipoPago varchar(50),
		@totalAlquiler float,
		@fecha date,
		@fechafinal date,
		@idcliente int,
		@idAlquiler int OUTPUT
AS
BEGIN TRY
		INSERT INTO Alquileres
		(
			TipodePago,
			TotalAlquiler,
			FechaInicio,
			FechaFinal,
			IdCliente
		)
		VALUES
		(
			@tipoPago,
			@totalAlquiler,
			@fecha,
			@fechafinal,
			@idcliente
		)
		
		SELECT @idAlquiler FROM Alquileres WHERE IdCliente = @idcliente 
			
END TRY
BEGIN CATCH

END CATCH
GO
