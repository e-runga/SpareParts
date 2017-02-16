CREATE TABLE [dbo].[ProductStatus] (
    [Id]   INT          IDENTITY (1, 1) NOT NULL,
    [Name] VARCHAR (20) NOT NULL,
    CONSTRAINT [PK_ProductStatus] PRIMARY KEY CLUSTERED ([Id] ASC)
);

