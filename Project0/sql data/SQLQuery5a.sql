--SET IDENTITY_INSERT PRODUCTS ON
--GO
--Insert into [PRODUCTS] (ProductId, ProductDescription, ProductPrice)
--VALUES (25, 'GTX 2080 TI' , 525);
SET IDENTITY_INSERT STORES ON
GO
Insert into [STORES] (StoreId, StoreLocation, StoreSaleID)
VALUES (02,'207 S Memorial Dr, Tulsa, OK 74112', 02),(03, '1275 Powers Ferry Rd Ste 50, Marietta, GA 30067', 03),(04,'32800 Concord Dr, Madison Heights, MI 48071', 04 );
