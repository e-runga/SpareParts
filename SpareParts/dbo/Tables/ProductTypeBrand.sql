CREATE TABLE [dbo].[ProductTypeBrand] (
    [BrandId]       INT NOT NULL,
    [ProductTypeId] INT NOT NULL,
    CONSTRAINT [PK_ProductTypeBrand] PRIMARY KEY CLUSTERED ([BrandId] ASC, [ProductTypeId] ASC),
    CONSTRAINT [FK_ProductTypeBrand_Brand] FOREIGN KEY ([BrandId]) REFERENCES [dbo].[Brand] ([Id]),
    CONSTRAINT [FK_ProductTypeBrand_ProductType] FOREIGN KEY ([ProductTypeId]) REFERENCES [dbo].[ProductType] ([Id])
);

