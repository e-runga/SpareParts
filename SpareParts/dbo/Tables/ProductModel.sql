CREATE TABLE [dbo].[ProductModel] (
    [ProductId] INT NOT NULL,
    [ModelId]   INT NOT NULL,
    CONSTRAINT [PK_ProductModel] PRIMARY KEY CLUSTERED ([ProductId] ASC, [ModelId] ASC),
    CONSTRAINT [FK_ProductModel_Model] FOREIGN KEY ([ModelId]) REFERENCES [dbo].[Model] ([Id]),
    CONSTRAINT [FK_ProductModel_Product] FOREIGN KEY ([ProductId]) REFERENCES [dbo].[Product] ([Id])
);

