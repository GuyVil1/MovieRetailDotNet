CREATE PROCEDURE [dbo].[GetAllActorByFilm]
	@Title varchar
AS
	SELECT * FROM Actor a INNER JOIN FilmActor fa 
	ON(a.ActorId = fa.ActorId)
	INNER JOIN Film f 
	ON(f.FilmId = fa.FilmId) 
	WHERE f.Title = @Title;  
RETURN 0