CREATE TABLE [dbo].[ProductBrand] (
    [ProductId] INT NOT NULL,
    [BrandId]   INT NOT NULL,
    CONSTRAINT [PK_ProductBrand] PRIMARY KEY CLUSTERED ([ProductId] ASC, [BrandId] ASC),
    CONSTRAINT [FK_ProductBrand_Brand] FOREIGN KEY ([BrandId]) REFERENCES [dbo].[Brand] ([Id]),
    CONSTRAINT [FK_ProductBrand_Product] FOREIGN KEY ([ProductId]) REFERENCES [dbo].[Product] ([Id])
);

