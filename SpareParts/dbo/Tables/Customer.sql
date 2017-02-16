CREATE TABLE [dbo].[Customer] (
    [Id]             INT           IDENTITY (1, 1) NOT NULL,
    [FirstName]      VARCHAR (100) NOT NULL,
    [LastName]       VARCHAR (100) NOT NULL,
    [Email]          VARCHAR (100) NULL,
    [Mobile]         VARCHAR (20)  NULL,
    [Phone]          VARCHAR (20)  NULL,
    [CustomerTypeId] INT           NOT NULL,
    CONSTRAINT [PK_Buyer] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Customer_CustomerType] FOREIGN KEY ([CustomerTypeId]) REFERENCES [dbo].[CustomerType] ([Id])
);




GO
CREATE NONCLUSTERED INDEX [IX_Customer_SearchCriteria]
    ON [dbo].[Customer]([FirstName] ASC, [LastName] ASC, [Email] ASC, [Mobile] ASC);

