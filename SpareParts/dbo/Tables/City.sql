CREATE TABLE [dbo].[City] (
    [Id]        INT          IDENTITY (1, 1) NOT NULL,
    [Name]      VARCHAR (50) NOT NULL,
    [CountryId] INT          NOT NULL,
    CONSTRAINT [PK_City] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_City_Country] FOREIGN KEY ([CountryId]) REFERENCES [dbo].[Country] ([Id])
);






GO
CREATE NONCLUSTERED INDEX [IX_City_Name]
    ON [dbo].[City]([Name] ASC);

