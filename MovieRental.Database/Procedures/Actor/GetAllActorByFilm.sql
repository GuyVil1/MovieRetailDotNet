CREATE PROCEDURE [dbo].[GetAllActorByFilm]
	@IdFilm int

AS
	SELECT * FROM Actor a, Film f, FilmActor fa WHERE a.ActorId = f.FilmId AND f.FilmId = @IdFilm;
RETURN 0
