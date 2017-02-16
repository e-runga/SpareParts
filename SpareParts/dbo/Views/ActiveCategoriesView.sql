CREATE VIEW dbo.[ActiveCategoriesView]
AS
	SELECT	Id,
			Name, 
			ParentId
	FROM	dbo.Category
	WHERE	IsActive = 1