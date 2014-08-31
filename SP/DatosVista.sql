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
-- Author:		pablo taddei
-- Create date: 25/06/2013
-- Description:	NOS TRAEMOS ESTOS DATOS DE LA VISTA CREADA
-- =============================================
CREATE PROCEDURE DatosVista
	---SIN PARAMETROS DE ENTRADA
AS
BEGIN
	SELECT * FROM ViewCompras 
END
GO
