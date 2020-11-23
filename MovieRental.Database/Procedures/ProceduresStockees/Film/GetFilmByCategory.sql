CREATE PROCEDURE [dbo].[GetFilmByCategory]
	@Name varchar
AS
	SELECT * FROM Film f, Category c, FilmCategory fc 
	WHERE f.FilmId = fc.FilmId
	AND c.CategoryId = fc.CategoryId
	AND c.Name = @Name;
RETURN 0
