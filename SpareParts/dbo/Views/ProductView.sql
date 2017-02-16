





CREATE VIEW [dbo].[ProductView]
AS
SELECT DISTINCT PROD.Id AS ProductId, 
				PROD.Name AS ProductName, 
				PROD.StateId AS [Status],
				PRST.Name AS StatusName,
				ISNULL(PROD.SellPrice, CAST(0 AS DECIMAL)) AS SellPrice,
				ISNULL(PROD.BuyingPrice, CAST(0 AS DECIMAL)) AS BuyingPrice,
				ISNULL(STUFF(( SELECT ', ' + BR.Name
						FROM Brand BR
						INNER JOIN ProductBrand PB ON BR.Id = PB.BrandId
						WHERE PB.ProductId = PROD.Id
						FOR XML PATH('')), 1, 1, ''
				), '') AS Brand, 
				CTRY.Name AS Country, 
				CITY.Name AS City, 
				ISNULL(STUFF(( SELECT ', ' + MO.Name
						FROM Model MO
						INNER JOIN ProductModel PM ON MO.Id = PM.ModelId
						WHERE PM.ProductId = PROD.Id
						FOR XML PATH('')), 1, 1, ''
				), '') AS Model,
				ISNULL(STUFF(( SELECT ', ' + CA.Name
						FROM Category CA
						INNER JOIN ProductCategory PC ON CA.Id = PC.CategoryId
						WHERE PC.ProductId = PROD.Id
						FOR XML PATH('')), 1, 1, ''
				), '') AS Category, 
				ISNULL(STUFF(( SELECT ', ' + CAST(YE.[Year] AS VARCHAR)
						FROM [Year] YE
						INNER JOIN ProductYear PY ON YE.Id = PY.YearId
						WHERE PY.ProductId = PROD.Id
						FOR XML PATH('')), 1, 1, ''
				), '') AS Years,
				ITEM.Name AS Item, 
				ISNULL(PROD.VehicleIdentificationNumber, '') AS VIN, 
				PRTY.Name AS ProductType, 
				STAT.Name AS State, 
				ISNULL(PROD.Sold, 0) AS Sold,
				ISNULL(PROD.HasOrder, 0) AS HasOrder,
				ISNULL(PROD.IsReimbursed, 0) AS IsReimbursed,
				ISNULL(PROD.IsReplace, 0) AS IsReplace,
				ISNULL(PROD.IsReturn, 0) AS IsReturn
FROM            Product				PROD
INNER JOIN		ProductType			PRTY ON PROD.ProductTypeId = PRTY.Id
INNER JOIN		City				CITY ON PROD.LocationId = CITY.Id
INNER JOIN		Country				CTRY ON CITY.CountryId = CTRY.Id
INNER JOIN		[State]				STAT ON PROD.StateId = STAT.Id
INNER JOIN		Item				ITEM ON PROD.ItemId = ITEM.Id
INNER JOIN		ProductStatus		PRST ON PROD.StatusId = PRST.Id

GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'ProductView';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'280
            TopColumn = 0
         End
         Begin Table = "SubModel"
            Begin Extent = 
               Top = 6
               Left = 1204
               Bottom = 102
               Right = 1374
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Category"
            Begin Extent = 
               Top = 434
               Left = 339
               Bottom = 530
               Right = 509
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ProductType"
            Begin Extent = 
               Top = 330
               Left = 310
               Bottom = 426
               Right = 480
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "State"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 102
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Location"
            Begin Extent = 
               Top = 6
               Left = 718
               Bottom = 119
               Right = 888
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Item"
            Begin Extent = 
               Top = 335
               Left = 55
               Bottom = 431
               Right = 225
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Product"
            Begin Extent = 
               Top = 71
               Left = 234
               Bottom = 201
               Right = 460
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 13
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 5085
         Alias = 2730
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'ProductView';




GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[46] 4[18] 2[16] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Brand"
            Begin Extent = 
               Top = 6
               Left = 510
               Bottom = 102
               Right = 680
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Country"
            Begin Extent = 
               Top = 132
               Left = 774
               Bottom = 228
               Right = 944
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Model"
            Begin Extent = 
               Top = 268
               Left = 779
               Bottom = 364
               Right = 949
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "SubCategory1"
            Begin Extent = 
               Top = 357
               Left = 574
               Bottom = 470
               Right = 744
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "SubCategory2"
            Begin Extent = 
               Top = 375
               Left = 781
               Bottom = 488
               Right = 954
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Year"
            Begin Extent = 
               Top = 138
               Left = 38
               Bottom = 234
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "City"
            Begin Extent = 
               Top = 17
               Left = 996
               Bottom = 130
               Right = 1166
            End
            DisplayFlags = ', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'ProductView';



