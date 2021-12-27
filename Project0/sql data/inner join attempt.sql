/****** Script for SelectTopNRows command from SSMS  ******/
SELECT PRODUCTS.ProductId, INVENTORY.ProductId
FROM PRODUCTS
INNER JOIN INVENTORY
on PRODUCTS.ProductId = INVENTORY.ProductId;