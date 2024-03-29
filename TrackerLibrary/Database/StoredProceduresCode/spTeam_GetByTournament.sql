USE [Tournaments]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[spTeam_GetByTournament]
	@TournamentId int
AS
BEGIN
	SET NOCOUNT ON;

	SELECT team.*
	FROM dbo.Teams team
	INNER JOIN dbo.TournamentEntries t ON team.id = t.TeamId
	WHERE t.TournamentId = @TournamentId
END
