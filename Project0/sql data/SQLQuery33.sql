/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [CustomerId]
      ,[FirstName]
      ,[LastName]
      ,[Username]
      ,[Password]
  FROM [Vendor].[dbo].[Customers]
