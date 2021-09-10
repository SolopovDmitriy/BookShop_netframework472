
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 08/23/2021 12:47:53
-- Generated from EDMX file: D:\c#\lesson88\BookShop_netframework472\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [bookShop];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_UserOrder]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[OrderSet] DROP CONSTRAINT [FK_UserOrder];
GO
IF OBJECT_ID(N'[dbo].[FK_GenreBook]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BookSet] DROP CONSTRAINT [FK_GenreBook];
GO
IF OBJECT_ID(N'[dbo].[FK_AuthorBook]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BookSet] DROP CONSTRAINT [FK_AuthorBook];
GO
IF OBJECT_ID(N'[dbo].[FK_PublisherBook]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BookSet] DROP CONSTRAINT [FK_PublisherBook];
GO
IF OBJECT_ID(N'[dbo].[FK_BookExemplarBook]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BookExemplarSet] DROP CONSTRAINT [FK_BookExemplarBook];
GO
IF OBJECT_ID(N'[dbo].[FK_StatusBookExemplar]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BookExemplarSet] DROP CONSTRAINT [FK_StatusBookExemplar];
GO
IF OBJECT_ID(N'[dbo].[FK_OrderBookExemplar]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BookExemplarSet] DROP CONSTRAINT [FK_OrderBookExemplar];
GO
IF OBJECT_ID(N'[dbo].[FK_BookBook]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BookSet] DROP CONSTRAINT [FK_BookBook];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[BookSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BookSet];
GO
IF OBJECT_ID(N'[dbo].[OrderSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[OrderSet];
GO
IF OBJECT_ID(N'[dbo].[UserSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserSet];
GO
IF OBJECT_ID(N'[dbo].[GenreSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[GenreSet];
GO
IF OBJECT_ID(N'[dbo].[AuthorSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AuthorSet];
GO
IF OBJECT_ID(N'[dbo].[PublisherSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PublisherSet];
GO
IF OBJECT_ID(N'[dbo].[StatusSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[StatusSet];
GO
IF OBJECT_ID(N'[dbo].[BookExemplarSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BookExemplarSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'BookSet'
CREATE TABLE [dbo].[BookSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [GenreId] int  NOT NULL,
    [AuthorId] int  NOT NULL,
    [Pages] int  NOT NULL,
    [Year] int  NOT NULL,
    [Cost] decimal(18,0)  NOT NULL,
    [Price] decimal(18,0)  NOT NULL,
    [PublisherId] int  NOT NULL,
    [CreatedAt] datetime  NOT NULL,
    [Previous_Id] int  NULL
);
GO

-- Creating table 'OrderSet'
CREATE TABLE [dbo].[OrderSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [UserId] int  NOT NULL,
    [CreatedAt] datetime  NOT NULL
);
GO

-- Creating table 'UserSet'
CREATE TABLE [dbo].[UserSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Login] nvarchar(50)  NOT NULL,
    [Password] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'GenreSet'
CREATE TABLE [dbo].[GenreSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'AuthorSet'
CREATE TABLE [dbo].[AuthorSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'PublisherSet'
CREATE TABLE [dbo].[PublisherSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'StatusSet'
CREATE TABLE [dbo].[StatusSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'BookExemplarSet'
CREATE TABLE [dbo].[BookExemplarSet] (
    [Id] int  NOT NULL,
    [BookId] int  NOT NULL,
    [StatusId] int  NOT NULL,
    [OrderId] int  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'BookSet'
ALTER TABLE [dbo].[BookSet]
ADD CONSTRAINT [PK_BookSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'OrderSet'
ALTER TABLE [dbo].[OrderSet]
ADD CONSTRAINT [PK_OrderSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'UserSet'
ALTER TABLE [dbo].[UserSet]
ADD CONSTRAINT [PK_UserSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'GenreSet'
ALTER TABLE [dbo].[GenreSet]
ADD CONSTRAINT [PK_GenreSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'AuthorSet'
ALTER TABLE [dbo].[AuthorSet]
ADD CONSTRAINT [PK_AuthorSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PublisherSet'
ALTER TABLE [dbo].[PublisherSet]
ADD CONSTRAINT [PK_PublisherSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'StatusSet'
ALTER TABLE [dbo].[StatusSet]
ADD CONSTRAINT [PK_StatusSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'BookExemplarSet'
ALTER TABLE [dbo].[BookExemplarSet]
ADD CONSTRAINT [PK_BookExemplarSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [UserId] in table 'OrderSet'
ALTER TABLE [dbo].[OrderSet]
ADD CONSTRAINT [FK_UserOrder]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[UserSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserOrder'
CREATE INDEX [IX_FK_UserOrder]
ON [dbo].[OrderSet]
    ([UserId]);
GO

-- Creating foreign key on [GenreId] in table 'BookSet'
ALTER TABLE [dbo].[BookSet]
ADD CONSTRAINT [FK_GenreBook]
    FOREIGN KEY ([GenreId])
    REFERENCES [dbo].[GenreSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_GenreBook'
CREATE INDEX [IX_FK_GenreBook]
ON [dbo].[BookSet]
    ([GenreId]);
GO

-- Creating foreign key on [AuthorId] in table 'BookSet'
ALTER TABLE [dbo].[BookSet]
ADD CONSTRAINT [FK_AuthorBook]
    FOREIGN KEY ([AuthorId])
    REFERENCES [dbo].[AuthorSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AuthorBook'
CREATE INDEX [IX_FK_AuthorBook]
ON [dbo].[BookSet]
    ([AuthorId]);
GO

-- Creating foreign key on [PublisherId] in table 'BookSet'
ALTER TABLE [dbo].[BookSet]
ADD CONSTRAINT [FK_PublisherBook]
    FOREIGN KEY ([PublisherId])
    REFERENCES [dbo].[PublisherSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PublisherBook'
CREATE INDEX [IX_FK_PublisherBook]
ON [dbo].[BookSet]
    ([PublisherId]);
GO

-- Creating foreign key on [BookId] in table 'BookExemplarSet'
ALTER TABLE [dbo].[BookExemplarSet]
ADD CONSTRAINT [FK_BookExemplarBook]
    FOREIGN KEY ([BookId])
    REFERENCES [dbo].[BookSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_BookExemplarBook'
CREATE INDEX [IX_FK_BookExemplarBook]
ON [dbo].[BookExemplarSet]
    ([BookId]);
GO

-- Creating foreign key on [StatusId] in table 'BookExemplarSet'
ALTER TABLE [dbo].[BookExemplarSet]
ADD CONSTRAINT [FK_StatusBookExemplar]
    FOREIGN KEY ([StatusId])
    REFERENCES [dbo].[StatusSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_StatusBookExemplar'
CREATE INDEX [IX_FK_StatusBookExemplar]
ON [dbo].[BookExemplarSet]
    ([StatusId]);
GO

-- Creating foreign key on [OrderId] in table 'BookExemplarSet'
ALTER TABLE [dbo].[BookExemplarSet]
ADD CONSTRAINT [FK_OrderBookExemplar]
    FOREIGN KEY ([OrderId])
    REFERENCES [dbo].[OrderSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_OrderBookExemplar'
CREATE INDEX [IX_FK_OrderBookExemplar]
ON [dbo].[BookExemplarSet]
    ([OrderId]);
GO

-- Creating foreign key on [Previous_Id] in table 'BookSet'
ALTER TABLE [dbo].[BookSet]
ADD CONSTRAINT [FK_BookBook]
    FOREIGN KEY ([Previous_Id])
    REFERENCES [dbo].[BookSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_BookBook'
CREATE INDEX [IX_FK_BookBook]
ON [dbo].[BookSet]
    ([Previous_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------