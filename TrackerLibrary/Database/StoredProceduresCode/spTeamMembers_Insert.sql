USE [Tournaments]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[spTeamMembers_Insert]
	@TeamId int,
	@PersonId int,
	@id int = 0 OUTPUT
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO dbo.TeamMembers (TeamId, PersonId)
	VALUES (@TeamId, @PersonId);

	SELECT @id = SCOPE_IDENTITY();
END
