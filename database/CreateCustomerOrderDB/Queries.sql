-- Get all customers who have NOT bought an item with id 100 in the last year.
SELECT c.CustomerName
FROM [Customer] c
WHERE NOT EXISTS
(
    SELECT * FROM [Order] o
    JOIN [OrderDetail] od ON od.OrderId = o.OrderId
    WHERE o.CustomerId = c.CustomerId
      AND od.ItemId = 100
      AND o.OrderDate > DATEADD(year,-1,GETDATE())
)

-- Get the single customer with the highest order amount on orders with 5 or more different items.
SELECT TOP 1 c.CustomerName
FROM [Customer] c
JOIN [Order] o ON o.CustomerId = c.CustomerId
WHERE
(
    SELECT COUNT(DISTINCT od.ItemId)
    FROM [OrderDetail] od
    WHERE od.OrderId = o.OrderId
) >=5
ORDER BY o.OrderAmount DESC

-- Get all items that have a quantity greater than 10 in an order and return the OrderId, OrderDate, CategoryName, ItemName and Quantity.
SELECT o.OrderId, o.OrderDate, c.CategoryName, i.ItemName, SUM(od.Quantity) AS Quantity
FROM [OrderDetail] od
JOIN [Order] o ON od.OrderId = o.OrderId
JOIN [Item] i ON i.ItemId = od.ItemId
JOIN [Category] c ON c.CategoryId = i.CategoryId
GROUP BY o.OrderId, o.OrderDate, c.CategoryName, i.ItemName, od.Quantity
HAVING SUM(od.Quantity) > 10

-- Set the status field to inactive for all customers who have not placed any order in the last year.
UPDATE [Customer]
SET Status = 0
FROM [Customer] c
WHERE NOT EXISTS
(
    SELECT *
    FROM [Order] o
    WHERE o.CustomerId = c.CustomerId
      AND o.OrderDate > DATEADD(year,-1,GETDATE())
)