/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [ProductId]
      ,[StoreId]
      ,[ProductCount]
  FROM [Vendor].[dbo].[INVENTORY]
 INSERT INTO [INVENTORY] (ProductId, StoreId, ProductCount)
 VALUES ('1', '1', '5'),
 ('2', '1' , '5'),
 ('3', '1' , '6'),
 ('4', '1', '6'),
 ('5', '1', '6'),
 ('6', '1', '6');

 INSERT INTO [ORDERS] (OrderId, CustomerId)
 VALUES ('123423', '12341');