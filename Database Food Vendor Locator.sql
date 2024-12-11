create database ai_project
CREATE TABLE Admin (
    AdminID INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100) NOT NULL,
    Email NVARCHAR(100)  ,
    PhoneNumber NVARCHAR(15)  ,
    Password NVARCHAR(255) NOT NULL
);
CREATE TABLE Vendor (
    vendor_id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100) NOT NULL,
    Email NVARCHAR(100)  ,
    PhoneNumber NVARCHAR(15)  ,
	Location varchar (250),
    Password NVARCHAR(255) NOT NULL
);
CREATE TABLE Customer (
    customer_id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100) NOT NULL,
    Email NVARCHAR(100)  ,
    PhoneNumber NVARCHAR(15)  ,
    Password NVARCHAR(255) NOT NULL
);
CREATE TABLE Item (
   item_id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100) NOT NULL,
    price INT NOT NULL,
    vendor_id INT,
    FOREIGN KEY (vendor_id) REFERENCES Vendor(vendor_id)

);

USE [ai_project]
GO

/****** Object:  Table [dbo].[ORDERT]    Script Date: 6/1/2024 11:12:44 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ORDERT](
	[Order_id] [int] IDENTITY(1,1) NOT NULL,
	[item_id] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Order_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[ORDERT]  WITH CHECK ADD FOREIGN KEY([item_id])
REFERENCES [dbo].[Item] ([item_id])
GO
ALTER TABLE Vendor
ADD CONSTRAINT chk_Location_https
CHECK (Location LIKE 'https%');