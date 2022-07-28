USE [Tournaments]
GO
/****** Object:  StoredProcedure [dbo].[spTeamMembers_Insert]    Script Date: 28.07.2022 21:14:25 ******/
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
