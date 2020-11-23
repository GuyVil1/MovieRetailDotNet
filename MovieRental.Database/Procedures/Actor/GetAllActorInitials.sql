CREATE PROCEDURE [dbo].[GetAllActorInitials]

AS
	SELECT SUBSTRING(firstName, 1), SUBSTRING(lastName, 1, 1) FROM Actor;
RETURN 0
