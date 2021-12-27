/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [ProductId]
      ,[StoreId]
      ,[ProductCount]
  FROM [Vendor].[dbo].[INVENTORY]
  SELECT PRODUCTS.ProductId, INVENTORY.ProductId
FROM PRODUCTS
INNER JOIN INVENTORY
on PRODUCTS.ProductId = INVENTORY.ProductId;


SELECT STORES.StoreId, INVENTORY.StoreId
FROM STORES
INNER JOIN INVENTORY
ON STORES.StoreId= Inventory.StoreId;




SELECT PRODUCTS.ProductName, PRODUCTS.ProductDescription
FROM PRODUCTS
INNER JOIN INVENTORY
ON PRODUCTS.ProductId=INVENTORY.ProductId
WHERE INVENTORY.StoreId=5;
