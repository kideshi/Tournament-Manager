USE [Tournaments]
GO
/****** Object:  StoredProcedure [dbo].[spTeam_GetByTournament]    Script Date: 28.07.2022 21:13:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[spTeam_GetByTournament]
	@TournamentId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	SELECT team.*
	FROM dbo.Teams team
	INNER JOIN dbo.TournamentEntries t ON team.id = t.TeamId
	WHERE t.TournamentId = @TournamentId

    
END
