/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [OrderId]
      ,[CustomerId]
      ,[SaleTotal]
      ,[ProductId]
  FROM [Vendor].[dbo].[Orders]


SET IDENTITY_INSERT Orders OFF
