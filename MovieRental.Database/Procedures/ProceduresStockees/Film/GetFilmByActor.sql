CREATE PROCEDURE [dbo].[GetFilmByActor]
	@LastName varchar
AS
	SELECT * FROM Film f, Actor a, FilmActor fa
	where a.ActorId = fa.ActorId
	AND f.FilmId = fa.FilmId
	AND a.LastName = @LastName;
RETURN 0
