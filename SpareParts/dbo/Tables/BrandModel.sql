CREATE TABLE [dbo].[BrandModel] (
    [BrandId] INT NOT NULL,
    [ModelId] INT NOT NULL,
    CONSTRAINT [PK_BrandModel] PRIMARY KEY CLUSTERED ([BrandId] ASC, [ModelId] ASC),
    CONSTRAINT [FK_BrandModel_Brand] FOREIGN KEY ([BrandId]) REFERENCES [dbo].[Brand] ([Id]),
    CONSTRAINT [FK_BrandModel_Model] FOREIGN KEY ([ModelId]) REFERENCES [dbo].[Model] ([Id])
);



