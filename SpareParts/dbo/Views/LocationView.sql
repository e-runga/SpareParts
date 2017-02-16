CREATE VIEW dbo.LocationView 
AS
SELECT	CITY.Id, CTRY.Name + ' (' + CITY.Name + ')' AS Location
FROM		City CITY
INNER JOIN	Country CTRY ON CITY.CountryId = CTRY.Id