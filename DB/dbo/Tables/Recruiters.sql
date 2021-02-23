CREATE TABLE [dbo].[Recruiters] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (MAX) NULL,
    [PhoneNumber] INT            NOT NULL,
    CONSTRAINT [PK_Recruiters] PRIMARY KEY CLUSTERED ([Id] ASC)
);

