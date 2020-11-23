CREATE PROCEDURE [dbo].[GetFilmByLanguage]
	@Language varchar
AS
	SELECT * FROM Film f, [Language] l WHERE f.LanguageId = l.LanguageId
	AND l.[Name] = @Language;
RETURN 0
