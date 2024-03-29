USE [Tournaments]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[spTeamMembers_GetByTeam]
	@TeamId int
AS
BEGIN
	SET NOCOUNT ON;

    SELECT p.* FROM dbo.TeamMembers m
	INNER JOIN dbo.People p ON m.PersonId = p.id
	WHERE m.TeamId = @TeamId; 
END
