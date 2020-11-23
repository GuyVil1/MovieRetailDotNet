CREATE PROCEDURE [dbo].[GetAllActorByFilm]
	@Title VARCHAR

AS
	SELECT * FROM Actor a, Film f, FilmActor fa WHERE a.ActorId = f.FilmId AND f.Title = @Title;
RETURN 0
