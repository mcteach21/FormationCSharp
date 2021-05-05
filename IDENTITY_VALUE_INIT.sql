-- IF OBJECT_ID('dbo.Identity_Cache_Demo', 'U') IS NOT NULL
-- DROP TABLE dbo.Identity_Cache_Demo;

CREATE TABLE [dbo].[Users2] (
    [Id]     INT  IDENTITY (1, 1) NOT NULL,
    [Prenom] NVARCHAR (50) NOT NULL,
    [Nom]    NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);