
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/17/2020 00:53:23
-- Generated from EDMX file: D:\Training\timetable_program\TimeTable_DB_Source\TimeTable_DB_Source\edmOrarend.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [D:\Training\timetable_program\TimeTable_DB_Source\TimeTable_DB_Source\db\TimeTable.mdf];
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

-- Creating table 'Tantargyak'
CREATE TABLE [dbo].[Tantargyak] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nev] nvarchar(max)  NOT NULL,
    [Oktato] nvarchar(max)  NOT NULL,
    [Tanterem_Id] int  NOT NULL,
    [Tanora_Id] int  NOT NULL
);
GO

-- Creating table 'Tantermek'
CREATE TABLE [dbo].[Tantermek] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nev] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'HaziFeladatok'
CREATE TABLE [dbo].[HaziFeladatok] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [HataridoNap] datetime  NOT NULL,
    [Tipusa] nvarchar(max)  NOT NULL,
    [Leirasa] nvarchar(max)  NOT NULL,
    [Tantargyak_Id] int  NOT NULL
);
GO

-- Creating table 'Tanorak'
CREATE TABLE [dbo].[Tanorak] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Kezdete] datetime  NOT NULL,
    [Hossza] int  NOT NULL,
    [Tanterem_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Tantargyak'
ALTER TABLE [dbo].[Tantargyak]
ADD CONSTRAINT [PK_Tantargyak]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Tantermek'
ALTER TABLE [dbo].[Tantermek]
ADD CONSTRAINT [PK_Tantermek]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'HaziFeladatok'
ALTER TABLE [dbo].[HaziFeladatok]
ADD CONSTRAINT [PK_HaziFeladatok]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Tanorak'
ALTER TABLE [dbo].[Tanorak]
ADD CONSTRAINT [PK_Tanorak]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Tanterem_Id] in table 'Tantargyak'
ALTER TABLE [dbo].[Tantargyak]
ADD CONSTRAINT [FK_TanteremOrarend]
    FOREIGN KEY ([Tanterem_Id])
    REFERENCES [dbo].[Tantermek]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TanteremOrarend'
CREATE INDEX [IX_FK_TanteremOrarend]
ON [dbo].[Tantargyak]
    ([Tanterem_Id]);
GO

-- Creating foreign key on [Tantargyak_Id] in table 'HaziFeladatok'
ALTER TABLE [dbo].[HaziFeladatok]
ADD CONSTRAINT [FK_TantargyHaziFeladat]
    FOREIGN KEY ([Tantargyak_Id])
    REFERENCES [dbo].[Tantargyak]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TantargyHaziFeladat'
CREATE INDEX [IX_FK_TantargyHaziFeladat]
ON [dbo].[HaziFeladatok]
    ([Tantargyak_Id]);
GO

-- Creating foreign key on [Tanterem_Id] in table 'Tanorak'
ALTER TABLE [dbo].[Tanorak]
ADD CONSTRAINT [FK_TanteremTanora]
    FOREIGN KEY ([Tanterem_Id])
    REFERENCES [dbo].[Tantermek]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TanteremTanora'
CREATE INDEX [IX_FK_TanteremTanora]
ON [dbo].[Tanorak]
    ([Tanterem_Id]);
GO

-- Creating foreign key on [Tanora_Id] in table 'Tantargyak'
ALTER TABLE [dbo].[Tantargyak]
ADD CONSTRAINT [FK_TanoraTantargy]
    FOREIGN KEY ([Tanora_Id])
    REFERENCES [dbo].[Tanorak]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TanoraTantargy'
CREATE INDEX [IX_FK_TanoraTantargy]
ON [dbo].[Tantargyak]
    ([Tanora_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------