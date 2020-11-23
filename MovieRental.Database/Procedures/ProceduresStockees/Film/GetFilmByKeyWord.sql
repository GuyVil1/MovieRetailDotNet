CREATE PROCEDURE [dbo].[GetFilmByKeyWord]
	@keyword varchar

AS
	SELECT * FROM Film WHERE Title like '%@Keyword%'
RETURN 0
