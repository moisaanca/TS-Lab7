
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/15/2020 18:49:32
-- Generated from EDMX file: C:\Users\anca.moisa\Desktop\facultate\WindowsFormsApp1\WindowsFormsApp1\Model1.edmx
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

IF OBJECT_ID(N'[dbo].[FK_InformationsTags]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[InformationsSet] DROP CONSTRAINT [FK_InformationsTags];
GO
IF OBJECT_ID(N'[dbo].[FK_PictureInformations]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[InformationsSet] DROP CONSTRAINT [FK_PictureInformations];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Picture]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Picture];
GO
IF OBJECT_ID(N'[dbo].[TagsSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TagsSet];
GO
IF OBJECT_ID(N'[dbo].[InformationsSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[InformationsSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Picture'
CREATE TABLE [dbo].[Picture] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [full_name] nvarchar(max)  NOT NULL,
    [path] nvarchar(max)  NOT NULL,
    [created_at] datetime  NOT NULL,
    [deleted] bit  NOT NULL
);
GO

-- Creating table 'TagsSet'
CREATE TABLE [dbo].[TagsSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'InformationsSet'
CREATE TABLE [dbo].[InformationsSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [description] nvarchar(max)  NOT NULL,
    [tag_id_Id] int  NOT NULL,
    [picture_id_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Picture'
ALTER TABLE [dbo].[Picture]
ADD CONSTRAINT [PK_Picture]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TagsSet'
ALTER TABLE [dbo].[TagsSet]
ADD CONSTRAINT [PK_TagsSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'InformationsSet'
ALTER TABLE [dbo].[InformationsSet]
ADD CONSTRAINT [PK_InformationsSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [tag_id_Id] in table 'InformationsSet'
ALTER TABLE [dbo].[InformationsSet]
ADD CONSTRAINT [FK_InformationsTags]
    FOREIGN KEY ([tag_id_Id])
    REFERENCES [dbo].[TagsSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_InformationsTags'
CREATE INDEX [IX_FK_InformationsTags]
ON [dbo].[InformationsSet]
    ([tag_id_Id]);
GO

-- Creating foreign key on [picture_id_Id] in table 'InformationsSet'
ALTER TABLE [dbo].[InformationsSet]
ADD CONSTRAINT [FK_PictureInformations]
    FOREIGN KEY ([picture_id_Id])
    REFERENCES [dbo].[Picture]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PictureInformations'
CREATE INDEX [IX_FK_PictureInformations]
ON [dbo].[InformationsSet]
    ([picture_id_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------