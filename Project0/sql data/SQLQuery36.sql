/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [CustomerId]
      ,[FirstName]
      ,[LastName]
      ,[Username]
      ,[Password]
  FROM [Vendor].[dbo].[Customers]

  SELECT * FROM STORES INNER JOIN INVENTORY ON STORES.StoreId = INVENTORY.StoreId  
      INNER JOIN PRODUCTS ON INVENTORY.ProductId = PRODUCTS.ProductId WHERE INVENTORY.StoreId = 1
