CREATE PROCEDURE [dbo].[GetFilmByTitle]
	@Title nvarchar(255)
AS
	SELECT * FROM Film WHERE Title like '%' + @Title + '%'
RETURN 0
