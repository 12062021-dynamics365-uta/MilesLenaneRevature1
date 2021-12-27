/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [ProductId]
      ,[StoreId]
      ,[ProductCount]
  FROM [Vendor].[dbo].[INVENTORY]
