CREATE TABLE [dbo].[Vacancies] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (MAX) NULL,
    [Price]       NVARCHAR (MAX) NULL,
    [Description] NVARCHAR (MAX) NULL,
    [CompanyId]   INT            NULL,
    CONSTRAINT [PK_Vacancies] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Vacancies_Companies_CompanyId] FOREIGN KEY ([CompanyId]) REFERENCES [dbo].[Companies] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_Vacancies_CompanyId]
    ON [dbo].[Vacancies]([CompanyId] ASC);

