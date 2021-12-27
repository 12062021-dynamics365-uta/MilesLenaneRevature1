/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [StoreId]
      ,[Storelocation]
  FROM [Vendor].[dbo].[STORES]

  SELECT ProductId, ProductName,ProductDescription,ProductPrice FROM PRODUCTS UNION 
  SELECT ProductCount from INVENTORY