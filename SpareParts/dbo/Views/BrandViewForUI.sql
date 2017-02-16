
CREATE VIEW [dbo].[BrandViewForUI]
AS
	SELECT	DISTINCT SUB.ProductTypeId, SUB.ProductType, SUB.BrandId, SUB.Brand, 
			STUFF((	SELECT DISTINCT ', ', + V.Model 
					FROM BrandView V 
					WHERE SUB.BrandId = V.BrandId 
					AND	SUB.ProductTypeId = V.ProductTypeId
					FOR XML PATH(''), TYPE
					).value('.', 'NVARCHAR(MAX)'), 1, 2, ''
				) Models
	FROM dbo.BrandView SUB