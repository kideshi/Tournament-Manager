USE [Tournaments]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[spTeam_GetAll]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT * FROM dbo.Teams;
END
