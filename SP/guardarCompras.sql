USE [VideoClub]
GO
/****** Object:  StoredProcedure [dbo].[guardarCompra]    Script Date: 04/25/2013 17:39:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		PABLO TADDEI
-- Create date: 24/04/2013
-- Description:	SP PARA GUARDAR LAS COMPRAS DE UN CLIENTE
-- =============================================
ALTER PROCEDURE [dbo].[guardarCompra]
		@TipoPago varchar(50),
		@total float,
		@totalCompra float,
		@fechaCompra date,
		@idcliente int,
		@idCompra int OUTPUT
AS
BEGIN TRY
	INSERT INTO Compras
	(
		TipodePago,
		Total,
		TotalCompra,
		FechadeCompra,
		IdCompra
	)
	VALUES
	(
		@TipoPago,
		@total,
		@totalCompra,
		@fechaCompra,
		@idcliente
	)
	SET @idCompra = 0
	SELECT @idCompra = IdCompra FROM Compras WHERE IdCliente = @idcliente
	 
END TRY
BEGIN CATCH
	PRINT ERROR_MESSAGE()
END CATCH
