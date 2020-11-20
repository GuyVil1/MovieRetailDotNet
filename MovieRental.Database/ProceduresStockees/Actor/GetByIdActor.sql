CREATE PROCEDURE [dbo].[GetByIdActor]
	@Id int

AS
	SELECT * FROM Actor WHERE ActorId = @Id;
RETURN 0
