CREATE TABLE [dbo].[Users] (
    [Id]         INT           IDENTITY (1, 1) NOT NULL,
    [FirstName]  VARCHAR (50)  NOT NULL,
    [LastName]   VARCHAR (50)  NOT NULL,
    [UserName]   VARCHAR (100) NULL,
    [Email]      VARCHAR (100) NULL,
    [Mobile]     VARCHAR (50)  NULL,
    [ProfilesId] INT           NOT NULL,
    [Password]   VARCHAR (250) NOT NULL,
    [Enabled] BIT NOT NULL DEFAULT 1, 
    CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Users_Profiles] FOREIGN KEY ([ProfilesId]) REFERENCES [dbo].[Profiles] ([Id])
);



