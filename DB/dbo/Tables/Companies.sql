CREATE TABLE [dbo].[Companies] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (MAX) NULL,
    [Location]    NVARCHAR (MAX) NULL,
    [RecruiterId] INT            NULL,
    CONSTRAINT [PK_Companies] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Companies_Recruiters_RecruiterId] FOREIGN KEY ([RecruiterId]) REFERENCES [dbo].[Recruiters] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_Companies_RecruiterId]
    ON [dbo].[Companies]([RecruiterId] ASC);

