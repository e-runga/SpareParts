CREATE VIEW dbo.ProductTypeBrandView 
AS
SELECT	 PRTY.Id	AS 'ProductTypeId',
		PRTY.Name	AS 'ProductType',
		ISNULL(STUFF(( SELECT ', ' + BR.Name
				FROM	Brand BR 
				INNER JOIN ProductTypeBrand PB ON BR.Id = PB.BrandId
				WHERE PB.ProductTypeId = PRTY.Id
				FOR XML PATH('')), 1, 1, ''
			  ), '') AS Brands 
FROM		ProductType	PRTY