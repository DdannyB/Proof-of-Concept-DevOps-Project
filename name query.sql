CREATE TABLE [Names] (
    [NameId] int NOT NULL IDENTITY,
    [NameLength] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_Name] PRIMARY KEY ([NameId])
);
GO