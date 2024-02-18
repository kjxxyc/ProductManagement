
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/16/2024 22:09:16
-- Generated from EDMX file: C:\Users\waske\source\repos\ProductManagement\ProductManagement\ProductManagement.Model\ModelProductManagement.edmx
-- --------------------------------------------------

CREATE DATABASE ProductManagementDB;
GO

SET QUOTED_IDENTIFIER OFF;
GO
USE [ProductManagementDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Products'
CREATE TABLE [dbo].[Products] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CodeProduct] nvarchar(15)  NOT NULL,
    [ProductName] nvarchar(100)  NOT NULL,
    [QuantityStock] decimal(9,2)  NOT NULL,
    [ImageProduct] varbinary(max)  NOT NULL,
    [Status] nvarchar(2)  NOT NULL,
    [CreatedDate] datetime  NOT NULL,
    [CreatedUserId] int  NOT NULL,
    [SupplierId] int  NOT NULL
);
GO

-- Creating table 'Options'
CREATE TABLE [dbo].[Options] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [OptionName] nvarchar(50)  NOT NULL,
    [Status] nvarchar(2)  NOT NULL,
    [CreatedDate] datetime  NOT NULL,
    [CreatedUserId] int  NOT NULL,
    [ProductId] int  NOT NULL
);
GO

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(50)  NOT NULL,
    [LastName] nvarchar(50)  NOT NULL,
    [UserName] nvarchar(15)  NOT NULL,
    [Password] nvarchar(100)  NOT NULL,
    [Email] nvarchar(100)  NOT NULL,
    [Telephone] nvarchar(8)  NOT NULL,
    [Status] nvarchar(2)  NOT NULL,
    [CreatedDate] datetime  NOT NULL
);
GO

-- Creating table 'Suppliers'
CREATE TABLE [dbo].[Suppliers] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [SupplierName] nvarchar(100)  NOT NULL,
    [Status] nvarchar(2)  NOT NULL,
    [CreatedDate] datetime  NOT NULL,
    [CreatedUserId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Products'
ALTER TABLE [dbo].[Products]
ADD CONSTRAINT [PK_Products]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Options'
ALTER TABLE [dbo].[Options]
ADD CONSTRAINT [PK_Options]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Suppliers'
ALTER TABLE [dbo].[Suppliers]
ADD CONSTRAINT [PK_Suppliers]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ProductId] in table 'Options'
ALTER TABLE [dbo].[Options]
ADD CONSTRAINT [FK_ProductOption]
    FOREIGN KEY ([ProductId])
    REFERENCES [dbo].[Products]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProductOption'
CREATE INDEX [IX_FK_ProductOption]
ON [dbo].[Options]
    ([ProductId]);
GO

-- Creating foreign key on [SupplierId] in table 'Products'
ALTER TABLE [dbo].[Products]
ADD CONSTRAINT [FK_SupplierProduct]
    FOREIGN KEY ([SupplierId])
    REFERENCES [dbo].[Suppliers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SupplierProduct'
CREATE INDEX [IX_FK_SupplierProduct]
ON [dbo].[Products]
    ([SupplierId]);
GO

-- Creating foreign key on [CreatedUserId] in table 'Suppliers'
ALTER TABLE [dbo].[Suppliers]
ADD CONSTRAINT [FK_UserSupplier]
    FOREIGN KEY ([CreatedUserId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserSupplier'
CREATE INDEX [IX_FK_UserSupplier]
ON [dbo].[Suppliers]
    ([CreatedUserId]);
GO

-- Creating foreign key on [CreatedUserId] in table 'Products'
ALTER TABLE [dbo].[Products]
ADD CONSTRAINT [FK_UserProduct]
    FOREIGN KEY ([CreatedUserId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserProduct'
CREATE INDEX [IX_FK_UserProduct]
ON [dbo].[Products]
    ([CreatedUserId]);
GO

-- Creating foreign key on [CreatedUserId] in table 'Options'
ALTER TABLE [dbo].[Options]
ADD CONSTRAINT [FK_UserOption]
    FOREIGN KEY ([CreatedUserId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserOption'
CREATE INDEX [IX_FK_UserOption]
ON [dbo].[Options]
    ([CreatedUserId]);
GO


-- --------------------------------------------------
-- Add Status CONSTRAINTS 
-- --------------------------------------------------

ALTER TABLE Users ADD CONSTRAINT CHK_Users_Status CHECK (Status IN ('AC','IN'));
GO

ALTER TABLE Products ADD CONSTRAINT CHK_Products_Status CHECK (Status IN ('AC','IN'));
GO

ALTER TABLE Suppliers ADD CONSTRAINT CHK_Suppliers_Status CHECK (Status IN ('AC','IN'));
GO

ALTER TABLE Options ADD CONSTRAINT CHK_Options_Status CHECK (Status IN ('AC','IN'));

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------