CREATE TABLE [dbo].[Attachment] (
    [Id]        INT             IDENTITY (1, 1) NOT NULL,
    [FileName]  VARCHAR (200)   NOT NULL,
    [Extension] VARCHAR (10)    NOT NULL,
    [MimeType]  VARCHAR (50)    NOT NULL,
    [Content]   VARBINARY (MAX) NOT NULL,
    [ProductId] INT             NOT NULL,
    CONSTRAINT [PK_Attachment] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Attachment_Product] FOREIGN KEY ([ProductId]) REFERENCES [dbo].[Product] ([Id])
);

