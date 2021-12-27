

CREATE TABLE Customers(
CustomerId INT PRIMARY KEY IDENTITY,
FirstName nvarchar(50) NOT NULL,
LastName nvarchar(10) NOT NULL,
Username nvarchar(max),
Password nvarchar(max),
);

CREATE TABLE PRODUCTS(
ProductId INT PRIMARY KEY IDENTITY NOT NULL,
ProductName nvarchar(50) NOT NULL,
ProductDescription nvarchar(MAX),
ProductPrice DECIMAL(7,2) NOT NULL,


);


CREATE TABLE Orders(
OrderId INT PRIMARY KEY IDENTITY NOT NULL,
CustomerId INT FOREIGN KEY REFERENCES Customers(CustomerId),
SaleTotal INT,
ProductId INT FOREIGN KEY REFERENCES PRODUCTS (ProductId), 

);

CREATE TABLE STORES(
StoreId INT PRIMARY KEY IDENTITY NOT NULL,
Storelocation nvarchar(50) NOT NULL,

);





CREATE TABLE INVENTORY(
ProductId INT FOREIGN KEY REFERENCES PRODUCTS(PRODUCTId) NOT NULL,
StoreId INT FOREIGN KEY REFERENCES STORES(StoreId),
ProductCount INT NOT NULL,

);

 








INSERT INTO PRODUCTS( ProductName, ProductDescription, ProductPrice)
	Values( '4.6 Gallon Tank', '20 pound propane tanks are often referred to as grill cylinders and hold 4.6 gallons of propane when full.', 5.99),
	( '60 Gallon Tank', '8" tall 12 " in diameter Very portable, easy to pick up', 15.99),
    ( '120 Gallon Tank', '120 gallon propane tanks hold 96 gallons of propane when full.', 22.99),
	( '250 Gallon Tank', 'A 250 gallon propane tank holds 200 gallons of propane when full.', 23.99),
	( '500 Gallon Tank', 'A 500 gallon propane tank holds 400 gallons of propane when full.', 33.99),
	( 'Vogner Charking Imperial','40,000 BTUs of clean burning propane fuel, I tell you hwat!', 359.99);


	INSERT INTO STORES (Storelocation)
	VALUES ('135 Los Gatos Road, Arlen TX, 73104'),
	('234 El Dorado Ln McMainerburry TX, 75324'),
	('455 E Farm to Market Rd 1382, Cedar Hill, TX 75104'),
	('1408 Armstrong Dr, DeSoto, TX 75115'),
	('1812 N Haskell Ave., Dallas, TX 75204'),
	('2008 N Main Ave, San Antonio, TX 78212');
