Select FirstName, LastName, CustomerId,Country from Customer 
Select * From Customer WHERE Country='Brazil' 
SELECT * FROM Employee WHERE Title LIKE '%Sales%'
SELECT BillingCountry FROM Invoice
SELECT Count (InvoiceDate) from Invoice WHERE InvoiceDate Like '%2009%'
SELECT Count(Quantity) FROM InvoiceLine where InvoiceId='37'
SELECT BillingCountry, Count (BillingCountry) from  Invoice Group by BillingCountry
SELECT BillingCountry, SUM(Total) FROM Invoice GROUP BY BillingCountry ORDER BY SUM(Total) DESC;
SELECT Quantity, SUM(Quantity) FROM InvoiceLine WHERE InvoiceId like '%10%' GROUP BY Quantity ORDER BY SUM(Quantity) DESC;


