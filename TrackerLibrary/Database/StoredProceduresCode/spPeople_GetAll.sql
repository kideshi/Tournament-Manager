USE [Tournaments]
GO
/****** Object:  StoredProcedure [dbo].[spPeople_GetAll]    Script Date: 28.07.2022 21:10:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[spPeople_GetAll] 
AS
BEGIN
	SET NOCOUNT ON;
	SELECT * FROM dbo.People;
END
