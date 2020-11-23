CREATE PROCEDURE [dbo].[GetFilmById]
	@Id int
AS
	SELECT * FROM Film WHERE FilmId = @id;
RETURN 0
