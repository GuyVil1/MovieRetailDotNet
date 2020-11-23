CREATE PROCEDURE [dbo].[GetActorById]
	@Id int

AS
	SELECT * FROM Actor WHERE ActorId = @Id;
RETURN 0
