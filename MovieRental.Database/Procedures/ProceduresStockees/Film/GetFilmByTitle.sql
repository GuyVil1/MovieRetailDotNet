CREATE PROCEDURE [dbo].[GetFilmByTitle]
	@Title varchar
AS
	SELECT * FROM Film WHERE Title = @Title;
RETURN 0
