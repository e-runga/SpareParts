


CREATE VIEW [dbo].[ModelView]
AS
	SELECT	MODE.Id, 
			MODE.Name AS 'Model',
			ISNULL(MOSM.SubModelId, 0) AS SubModelId,
			ISNULL(SUBM.Name, '') AS 'SubModel'
	FROM	Model	MODE
	LEFT JOIN ModelSubModel MOSM ON MODE.Id = MOSM.ModelId
	LEFT JOIN SubModel SUBM ON MOSM.SubModelId = SUBM.Id