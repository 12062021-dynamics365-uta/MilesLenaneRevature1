/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [StoreId]
      ,[Storelocation]
  FROM [Vendor].[dbo].[STORES]


  SELECT * FROM STORES  
 LEFT JOIN INVENTORY ON STORES.StoreId = INVENTORY.StoreId
 LEFT JOIN PRODUCTS ON INVENTORY.ProductId = PRODUCTS.ProductId