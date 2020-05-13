
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/13/2020 12:51:23
-- Generated from EDMX file: C:\Users\Owner\Desktop\College Work\OOD\LukeBrowne_S00187306\LukeBrowne_S00187306\Phone.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [phoneDetails];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'details'
CREATE TABLE [dbo].[details] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Price] nvarchar(max)  NOT NULL,
    [OperatingSystem] nvarchar(max)  NOT NULL,
    [OS_Image] nvarchar(max)  NOT NULL,
    [Phone_Image] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'details'
ALTER TABLE [dbo].[details]
ADD CONSTRAINT [PK_details]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------