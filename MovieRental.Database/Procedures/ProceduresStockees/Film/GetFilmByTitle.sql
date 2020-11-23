CREATE PROCEDURE [dbo].[GetFilmByTitle]

@title varchar
AS
	SELECT * FROM Film WHERE Title = @title
RETURN 0
