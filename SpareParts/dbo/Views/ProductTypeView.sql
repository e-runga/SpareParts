



CREATE VIEW [dbo].[ProductTypeView]
AS
	SELECT	PRTY.Id, PRTY.Name,
			ISNULL(STUFF(( SELECT ', ' + BR.Name
					FROM	ProductType PT
					INNER JOIN ProductTypeBrand PB ON PT.Id = PB.ProductTypeId
					INNER JOIN Brand BR ON PB.BrandId = BR.Id
					WHERE PT.Id = PRTY.Id
					FOR XML PATH('')), 1, 1, ''
				   ), '') AS 'Brands',
			ISNULL(STUFF(( SELECT ', ' + CA.Name
					FROM	ProductType PT
					INNER JOIN ProductTypeCategory PC ON PT.Id = PC.ProductTypeId
					INNER JOIN Category CA ON PC.CategoryId = CA.Id
					WHERE PT.Id = PRTY.Id
					FOR XML PATH('')), 1, 1, ''
				  ), '') AS 'Categories'
	FROM	ProductType PRTY