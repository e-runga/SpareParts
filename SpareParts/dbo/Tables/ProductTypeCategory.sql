CREATE TABLE [dbo].[ProductTypeCategory] (
    [ProductTypeId] INT NOT NULL,
    [CategoryId]    INT NOT NULL,
    CONSTRAINT [PK_ProductTypeCategory] PRIMARY KEY CLUSTERED ([ProductTypeId] ASC, [CategoryId] ASC),
    CONSTRAINT [FK_ProductTypeCategory_Category] FOREIGN KEY ([CategoryId]) REFERENCES [dbo].[Category] ([Id]),
    CONSTRAINT [FK_ProductTypeCategory_ProductType] FOREIGN KEY ([ProductTypeId]) REFERENCES [dbo].[ProductType] ([Id])
);

