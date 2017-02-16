CREATE TABLE [dbo].[Category] (
    [Id]       INT           IDENTITY (1, 1) NOT NULL,
    [Name]     VARCHAR (100) NOT NULL,
    [ParentId] INT           NULL,
    [IsActive] BIT           CONSTRAINT [DF_Category_IsActive] DEFAULT ((1)) NOT NULL,
    CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Category_SubCategory] FOREIGN KEY ([ParentId]) REFERENCES [dbo].[Category] ([Id])
);










GO
CREATE NONCLUSTERED INDEX [IX_Category_Name]
    ON [dbo].[Category]([Name] ASC);

