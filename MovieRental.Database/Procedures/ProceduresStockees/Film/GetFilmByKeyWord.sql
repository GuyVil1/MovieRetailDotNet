CREATE PROCEDURE [dbo].[GetFilmByKeyWord]
	@KeyWord varchar
AS
	SELECT * FROM Film  WHERE [Description] like '%' + @KeyWord + '%'
RETURN 0
