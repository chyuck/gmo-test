USE [CustomerOrders]
GO

-- drop tables
IF OBJECT_ID('OrderDetail') > 0
    DROP TABLE [OrderDetail]
GO

IF OBJECT_ID('Item') > 0
    DROP TABLE [Item]
GO

IF OBJECT_ID('Category') > 0
    DROP TABLE [Category]
GO

IF OBJECT_ID('Order') > 0
    DROP TABLE [Order]
GO

IF OBJECT_ID('Customer') > 0
    DROP TABLE [Customer]
GO


-- create tables
CREATE TABLE [Customer]
(
    [CustomerId] INT NOT NULL IDENTITY PRIMARY KEY,
    [CustomerName] VARCHAR(100) NOT NULL,
    [Status] BIT NOT NULL
)
GO

CREATE TABLE [Order]
(
    [OrderId] INT NOT NULL IDENTITY PRIMARY KEY,
    [CustomerId] INT NOT NULL REFERENCES Customer(CustomerId),
    [OrderDate] SMALLDATETIME NOT NULL,
    [OrderAmount] MONEY NOT NULL
)
GO

CREATE TABLE [Category]
(
    [CategoryId] INT NOT NULL IDENTITY PRIMARY KEY,
    [CategoryName] VARCHAR(50),
    CONSTRAINT UC_CategoryName UNIQUE (CategoryName)
)
GO

CREATE TABLE [Item]
(
    [ItemId] INT NOT NULL IDENTITY PRIMARY KEY,
    [CategoryId] INT NOT NULL REFERENCES Category(CategoryId),
    [ItemName] VARCHAR(50),
    CONSTRAINT UC_ItemName UNIQUE (ItemName)
)
GO

CREATE TABLE [OrderDetail]
(
    [OrderId] INT NOT NULL REFERENCES [Order](OrderId),
    [ItemId] INT NOT NULL REFERENCES Item(ItemId),
    [Quantity] INT NOT NULL,
    [Amount] MONEY NOT NULL
)
GO
