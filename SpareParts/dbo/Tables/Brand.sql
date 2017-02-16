CREATE TABLE [dbo].[Brand] (
    [Id]   INT           IDENTITY (1, 1) NOT NULL,
    [Name] VARCHAR (100) NOT NULL,
    CONSTRAINT [PK_Brand] PRIMARY KEY CLUSTERED ([Id] ASC)
);








GO
CREATE NONCLUSTERED INDEX [IX_Brand_Name]
    ON [dbo].[Brand]([Name] ASC);

