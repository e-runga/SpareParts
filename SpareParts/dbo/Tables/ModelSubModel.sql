CREATE TABLE [dbo].[ModelSubModel] (
    [ModelId]    INT NOT NULL,
    [SubModelId] INT NOT NULL,
    CONSTRAINT [PK_ModelSubModel] PRIMARY KEY CLUSTERED ([ModelId] ASC, [SubModelId] ASC),
    CONSTRAINT [FK_ModelSubModel_Model] FOREIGN KEY ([ModelId]) REFERENCES [dbo].[Model] ([Id]),
    CONSTRAINT [FK_ModelSubModel_SubModel] FOREIGN KEY ([SubModelId]) REFERENCES [dbo].[SubModel] ([Id])
);



