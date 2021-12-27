CREATE TABLE Addresses(
Addressid INT PRIMARY KEY IDENTITY,
AddressLine1 nvarchar(50) NOT NULL,
AddressLine2 nvarchar(50) NULL,
City nvarchar(100) NULL,
CountryCode nchar(3) NULL);

CREATE TABLE Customers(
CustomerId INT PRIMARY KEY IDENTITY,
FirstName nvarchar(50) NOT NULL,
LastName nvarchar(10) NOT NULL,
AddressID INT NOT NULL FOREIGN KEY REFERENCES Addresses(Addressid) ON DELETE CASCADE,
LastOrderDate date NULL,
Remarks nvarchar(250) NULL);

CREATE TABLE PRODUCTS(
INT PRIMARY KEY IDENTITY  ProductId NOT NULL,
ProductDescription nvarchar(MAX)

);


CREATE TABLE Orders(
OrderD INT PRIMARY KEY IDENTITY NOT NULL,
CustomerId INT FOREIGN KEY REFERENCES Customers(CustomerId),
SaleTotal INT NOT NULL,
ProductId INT FOREIGN KEY REFERENCES 


);

CREATE TABLE STORES(
StoreId INT PRIMARY KEY IDENTITY NOT NULL,
Storelocation nvarchar(50) NOT NULL,
StoreSaleID INT not null FOREIGN KEY references stores(StoreID),
CustomerId INT FOREIGN KEY REFERENCES (Customers(CustomerId),
);





CREATE TABLE INVENTORY(

ProductId FOREIGN KEY REFERENCES PRODUCTS(PRODUCTId) NOT NULL,
ProductName nvarchar(50) NOT NULL,
StoreId INT FOREIGN KEY REFERENCES STORES(
ProductPrice INT NOT NULL,
ProductDescription nvarchar(max) NOT NULL,
ProductCount INT NOT NULL,

);
