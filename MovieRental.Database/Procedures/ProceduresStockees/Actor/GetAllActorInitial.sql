﻿CREATE PROCEDURE [dbo].[GetAllActorInitial]
AS
	SELECT SUBSTRING(FirstName, 1, 1), SUBSTRING(LastName, 1, 1) FROM Actor;
RETURN 0