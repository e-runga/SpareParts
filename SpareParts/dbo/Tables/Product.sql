CREATE TABLE [dbo].[Product] (
    [Id]                          INT             IDENTITY (1, 1) NOT NULL,
    [Name]                        VARCHAR (250)   NULL,
    [ItemId]                      INT             NOT NULL,
    [ProductTypeId]               INT             NOT NULL,
    [PaperReferenceId]            INT             NULL,
    [LocationId]                  INT             NOT NULL,
    [StockLocation]               VARCHAR (50)    NULL,
    [CustomerId]                  INT             NOT NULL,
    [OperatorId]                  INT             NOT NULL,
    [RatingId]                    INT             NULL,
    [DepositBuyDate]              DATETIME        CONSTRAINT [DF_Product_DepositBuyDate] DEFAULT (getdate()) NOT NULL,
    [BuyingPrice]                 DECIMAL (18, 2) NULL,
    [Sold]                        BIT             CONSTRAINT [DF_Product_Sold] DEFAULT ((0)) NOT NULL,
    [SellPrice]                   DECIMAL (18, 2) CONSTRAINT [DF_Product_SellPrice] DEFAULT ((0.0)) NULL,
    [SellingOperatorId]           INT             NULL,
    [BuyerId]                     INT             NULL,
    [Mecanic]                     BIT             NULL,
    [SellingDate]                 DATETIME        NULL,
    [VehicleIdentificationNumber] VARCHAR (80)    NULL,
    [CarIdentificationNumber]     VARCHAR (70)    NULL,
    [HasComplaint]                BIT             NULL,
    [ComplaintOperatorId]         INT             NULL,
    [ComplaintDate]               DATETIME        NULL,
    [IsReturn]                    BIT             NULL,
    [ReturnOperatorId]            INT             NULL,
    [ReturnDate]                  DATETIME        NULL,
    [IsReplace]                   BIT             NULL,
    [ReplaceOperatorId]           INT             NULL,
    [ReplaceDate]                 DATETIME        NULL,
    [ReplacedProductId]           INT             NULL,
    [IsReimbursed]                BIT             NULL,
    [IsAvailable]                 BIT             NULL,
    [RequestNumber]               VARCHAR (100)   NULL,
    [RequestDate]                 DATETIME        NULL,
    [RequestOperatorId]           INT             NULL,
    [HasOrder]                    BIT             NULL,
    [OrderNumber]                 VARCHAR (100)   NULL,
    [OrderDate]                   DATETIME        NULL,
    [OrderOperatorId]             INT             NULL,
    [OrderCustomerId]             INT             NULL,
    [OrderSellingPrice]           DECIMAL (18, 2) CONSTRAINT [DF_Product_OrderSellingPrice] DEFAULT ((0.0)) NULL,
    [AdvancePaymentAmount]        DECIMAL (18, 2) CONSTRAINT [DF_Product_AdvancePaymentAmount] DEFAULT ((0.0)) NULL,
    [EstimatedDeliveryDate]       DATETIME        NULL,
    [FinalDate]                   DATETIME        NULL,
    [BalanceAmount]               DECIMAL (18, 2) CONSTRAINT [DF_Product_BalanceAmount] DEFAULT ((0.0)) NULL,
    [StateId]                     INT             NOT NULL,
    [SubModelId]                  INT             NULL,
    [StatusId]                    INT             CONSTRAINT [DF_Product_StatusId] DEFAULT ((1)) NOT NULL,
    CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Product_Buyer] FOREIGN KEY ([BuyerId]) REFERENCES [dbo].[Customer] ([Id]),
    CONSTRAINT [FK_Product_City] FOREIGN KEY ([LocationId]) REFERENCES [dbo].[City] ([Id]),
    CONSTRAINT [FK_Product_ComplaintOperator] FOREIGN KEY ([ComplaintOperatorId]) REFERENCES [dbo].[Users] ([Id]),
    CONSTRAINT [FK_Product_CustomerCreator] FOREIGN KEY ([CustomerId]) REFERENCES [dbo].[Customer] ([Id]),
    CONSTRAINT [FK_Product_Item] FOREIGN KEY ([ItemId]) REFERENCES [dbo].[Item] ([Id]),
    CONSTRAINT [FK_Product_OperatorCreator] FOREIGN KEY ([OperatorId]) REFERENCES [dbo].[Users] ([Id]),
    CONSTRAINT [FK_Product_OrderCustomer] FOREIGN KEY ([OrderCustomerId]) REFERENCES [dbo].[Customer] ([Id]),
    CONSTRAINT [FK_Product_OrderOperator] FOREIGN KEY ([OrderOperatorId]) REFERENCES [dbo].[Users] ([Id]),
    CONSTRAINT [FK_Product_PaperReference] FOREIGN KEY ([PaperReferenceId]) REFERENCES [dbo].[PaperReference] ([Id]),
    CONSTRAINT [FK_Product_ProductStatus] FOREIGN KEY ([StatusId]) REFERENCES [dbo].[ProductStatus] ([Id]),
    CONSTRAINT [FK_Product_ProductType] FOREIGN KEY ([ProductTypeId]) REFERENCES [dbo].[ProductType] ([Id]),
    CONSTRAINT [FK_Product_Rating] FOREIGN KEY ([RatingId]) REFERENCES [dbo].[Rating] ([Id]),
    CONSTRAINT [FK_Product_ReplaceOperator] FOREIGN KEY ([ReplaceOperatorId]) REFERENCES [dbo].[Users] ([Id]),
    CONSTRAINT [FK_Product_RequestOperator] FOREIGN KEY ([RequestOperatorId]) REFERENCES [dbo].[Users] ([Id]),
    CONSTRAINT [FK_Product_ReturnOperator] FOREIGN KEY ([ReturnOperatorId]) REFERENCES [dbo].[Users] ([Id]),
    CONSTRAINT [FK_Product_SellingOperator] FOREIGN KEY ([SellingOperatorId]) REFERENCES [dbo].[Users] ([Id]),
    CONSTRAINT [FK_Product_State] FOREIGN KEY ([StateId]) REFERENCES [dbo].[State] ([Id])
);




















GO
CREATE NONCLUSTERED INDEX [IX_Product_SearchCriteria]
    ON [dbo].[Product]([Name] ASC, [DepositBuyDate] ASC, [Sold] ASC, [VehicleIdentificationNumber] ASC, [CarIdentificationNumber] ASC, [HasComplaint] ASC, [ComplaintDate] ASC, [IsReturn] ASC, [ReturnDate] ASC, [IsReplace] ASC, [ReplaceDate] ASC, [RequestNumber] ASC, [RequestDate] ASC, [OrderNumber] ASC, [OrderDate] ASC, [FinalDate] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_Product_ForeignKeys]
    ON [dbo].[Product]([Name] ASC, [ItemId] ASC, [ProductTypeId] ASC, [LocationId] ASC, [VehicleIdentificationNumber] ASC, [StateId] ASC);

