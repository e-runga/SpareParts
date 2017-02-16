CREATE TABLE [dbo].[PaperReference] (
    [Id]   INT           IDENTITY (1, 1) NOT NULL,
    [Name] VARCHAR (200) NOT NULL,
    CONSTRAINT [PK_PaperReference] PRIMARY KEY CLUSTERED ([Id] ASC)
);



