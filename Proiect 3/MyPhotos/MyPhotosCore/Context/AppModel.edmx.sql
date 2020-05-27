
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/15/2020 16:38:45
-- Generated from EDMX file: E:\CURSURI\AN 3\TSP.NET\MyPhotos\MyPhotosCore\Context\AppModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Project];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_PhotoPerson_Photo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PhotoPerson] DROP CONSTRAINT [FK_PhotoPerson_Photo];
GO
IF OBJECT_ID(N'[dbo].[FK_PhotoPerson_Person]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PhotoPerson] DROP CONSTRAINT [FK_PhotoPerson_Person];
GO
IF OBJECT_ID(N'[dbo].[FK_LocationPhoto]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Photos] DROP CONSTRAINT [FK_LocationPhoto];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Photos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Photos];
GO
IF OBJECT_ID(N'[dbo].[People]', 'U') IS NOT NULL
    DROP TABLE [dbo].[People];
GO
IF OBJECT_ID(N'[dbo].[Locations]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Locations];
GO
IF OBJECT_ID(N'[dbo].[PhotoPerson]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PhotoPerson];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Photos'
CREATE TABLE [dbo].[Photos] (
    [PhotoId] int IDENTITY(1,1) NOT NULL,
    [DateCreated] datetime  NOT NULL,
    [Description] nvarchar(200)  NOT NULL,
    [Event] nvarchar(30)  NOT NULL,
    [FilePath] nvarchar(max)  NOT NULL,
    [LocationId] int  NOT NULL
);
GO

-- Creating table 'People'
CREATE TABLE [dbo].[People] (
    [PersonId] int IDENTITY(1,1) NOT NULL,
    [FirstName] nvarchar(15)  NOT NULL,
    [LastName] nvarchar(15)  NOT NULL
);
GO

-- Creating table 'Locations'
CREATE TABLE [dbo].[Locations] (
    [LocationId] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'PhotoPerson'
CREATE TABLE [dbo].[PhotoPerson] (
    [Photos_PhotoId] int  NOT NULL,
    [People_PersonId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [PhotoId] in table 'Photos'
ALTER TABLE [dbo].[Photos]
ADD CONSTRAINT [PK_Photos]
    PRIMARY KEY CLUSTERED ([PhotoId] ASC);
GO

-- Creating primary key on [PersonId] in table 'People'
ALTER TABLE [dbo].[People]
ADD CONSTRAINT [PK_People]
    PRIMARY KEY CLUSTERED ([PersonId] ASC);
GO

-- Creating primary key on [LocationId] in table 'Locations'
ALTER TABLE [dbo].[Locations]
ADD CONSTRAINT [PK_Locations]
    PRIMARY KEY CLUSTERED ([LocationId] ASC);
GO

-- Creating primary key on [Photos_PhotoId], [People_PersonId] in table 'PhotoPerson'
ALTER TABLE [dbo].[PhotoPerson]
ADD CONSTRAINT [PK_PhotoPerson]
    PRIMARY KEY CLUSTERED ([Photos_PhotoId], [People_PersonId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Photos_PhotoId] in table 'PhotoPerson'
ALTER TABLE [dbo].[PhotoPerson]
ADD CONSTRAINT [FK_PhotoPerson_Photo]
    FOREIGN KEY ([Photos_PhotoId])
    REFERENCES [dbo].[Photos]
        ([PhotoId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [People_PersonId] in table 'PhotoPerson'
ALTER TABLE [dbo].[PhotoPerson]
ADD CONSTRAINT [FK_PhotoPerson_Person]
    FOREIGN KEY ([People_PersonId])
    REFERENCES [dbo].[People]
        ([PersonId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PhotoPerson_Person'
CREATE INDEX [IX_FK_PhotoPerson_Person]
ON [dbo].[PhotoPerson]
    ([People_PersonId]);
GO

-- Creating foreign key on [LocationId] in table 'Photos'
ALTER TABLE [dbo].[Photos]
ADD CONSTRAINT [FK_LocationPhoto]
    FOREIGN KEY ([LocationId])
    REFERENCES [dbo].[Locations]
        ([LocationId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_LocationPhoto'
CREATE INDEX [IX_FK_LocationPhoto]
ON [dbo].[Photos]
    ([LocationId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------