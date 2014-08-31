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
-- Author:		Pablo Taddei
-- Create date: 21/06/2013
-- Description:	MODIFICACION DE LA FECHA FINAL DE UN ALQUILER ESTO SE PRODUCE CUANDO FINALIZA UN ALQUILER
-- =============================================
CREATE PROCEDURE ModificacionFechafinalAlq
	@idAlquiler int,
	@fechaDevolucion date
AS
BEGIN TRY
	UPDATE Alquileres SET FechaFinal = @fechaDevolucion WHERE IdAlquiler = @idAlquiler 
END TRY
BEGIN CATCH
	PRINT ERROR_MESSAGE()
END CATCH
