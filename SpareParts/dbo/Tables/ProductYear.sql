CREATE TABLE [dbo].[ProductYear] (
    [Id]        INT IDENTITY (1, 1) NOT NULL,
    [ProductId] INT NOT NULL,
    [YearId]    INT NOT NULL,
    CONSTRAINT [PK_ProductYear] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_ProductYear_Product] FOREIGN KEY ([ProductId]) REFERENCES [dbo].[Product] ([Id]),
    CONSTRAINT [FK_ProductYear_Year] FOREIGN KEY ([YearId]) REFERENCES [dbo].[Year] ([Id])
);



