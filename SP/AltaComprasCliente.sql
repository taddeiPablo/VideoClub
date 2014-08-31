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
-- Create date: 25/04/2013
-- Description:	ALTA DE COMPRAS DEL CLIENTE
-- =============================================
CREATE PROCEDURE AltaComprasCliente
	@TipodePago varchar(50),
	@Total float,
	@TotalCompra float,
	@FechadeCompra date,
	@IdCliente int,
	@IdCompra int OUTPUT
AS
BEGIN TRY
	INSERT INTO Compras
	(
		TipodePago,
		Total,
		TotalCompra,
		FechadeCompra,
		IdCliente 
	)
	VALUES
	(
		@TipodePago,
		@Total,
		@TotalCompra,
		@FechadeCompra,
		@IdCliente
	)
	SET @IdCompra = 0
	SELECT @IdCompra = IdCompra  FROM Compras WHERE IdCliente = @IdCliente 
END TRY
BEGIN CATCH


END CATCH
GO
