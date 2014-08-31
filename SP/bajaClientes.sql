USE [VideoClub]
GO
/****** Object:  StoredProcedure [dbo].[borrarCliente]    Script Date: 04/28/2013 07:32:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Pablo Taddei
-- Create date: 14/04/2013
-- Description:	Procedimiento almacenado para borrar un cliente.
-- =============================================
ALTER PROCEDURE [dbo].[borrarCliente]
			
			@idCliente int
AS
BEGIN TRY
	
	-----CONSULTA PARA ELIMINAR UN REGISTRO DE LA TABLA DE CLIENTES :
	-----POSIBLE SOLUCION PARA BORRAR UN CLIENTE Y TODA SU INFO RELACIONADA

	--peliculas alquiladas
	DELETE ListaPeliculasAlquiladas  FROM ListaPeliculasAlquiladas 
	WHERE ListaPeliculasAlquiladas.IdAlquiler  in
	( 
		SELECT ListaPeliculasAlquiladas.idAlquiler FROM ListaPeliculasAlquiladas  INNER JOIN Alquileres ON ListaPeliculasAlquiladas.idAlquiler = Alquileres.idAlquiler
		INNER JOIN Clientes ON ListaPeliculasAlquiladas.idAlquiler = Alquileres.idAlquiler WHERE Alquileres.idCliente = @idCliente
	)

	---peliculas compradas
	DELETE ListaPeliculasCompras  FROM ListaPeliculasCompras 
	WHERE ListaPeliculasCompras.IdCompra in
	( 
		SELECT ListaPeliculasCompras.IdCompra FROM ListaPeliculasCompras  INNER JOIN Compras ON ListaPeliculasCompras.IdCompra = Compras.IdCompra
		INNER JOIN Clientes ON ListaPeliculasCompras.IdCompra = Compras.IdCompra WHERE Compras.idCliente = @idCliente
	)


	--alquileres
	DELETE Alquileres FROM Alquileres
	WHERE Alquileres.IdCliente in
	(
		SELECT Alquileres.IdCliente FROM Alquileres INNER JOIN Clientes ON Alquileres.IdCliente = @idCliente
	)

	--compras
	DELETE Compras FROM Compras
	WHERE Compras.IdCliente in
	(
		SELECT Compras.IdCliente FROM Compras INNER JOIN Clientes ON Compras.IdCliente = @idCliente
	)

	--se elimina al final el cliente
	DELETE FROM Clientes WHERE Clientes.IdCliente = @idCliente

END TRY
BEGIN CATCH
	PRINT ERROR_MESSAGE()
END CATCH

