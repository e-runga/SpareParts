CREATE TABLE [dbo].[Rating] (
    [Id]     INT             IDENTITY (1, 1) NOT NULL,
    [Name]   VARCHAR (50)    NOT NULL,
    [Amount] DECIMAL (18, 2) NOT NULL,
    CONSTRAINT [PK_Rating] PRIMARY KEY CLUSTERED ([Id] ASC)
);

