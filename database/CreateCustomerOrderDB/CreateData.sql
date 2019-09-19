USE [CustomerOrders]
GO

INSERT INTO  [Customer](CustomerName, Status) VALUES ('Alan Smith', 1);
INSERT INTO  [Customer](CustomerName, Status) VALUES ('David De Gea', 1);
INSERT INTO  [Customer](CustomerName, Status) VALUES ('Ashley Young', 1);

INSERT INTO  [Category](CategoryName) VALUES ('Sport Goods');
INSERT INTO  [Category](CategoryName) VALUES ('Grocery');


INSERT INTO  [Item](CategoryId, ItemName) VALUES (1, 'Football');
INSERT INTO  [Item](CategoryId, ItemName) VALUES (1, 'Basketball');
INSERT INTO  [Item](CategoryId, ItemName) VALUES (2, 'Milk');
INSERT INTO  [Item](CategoryId, ItemName) VALUES (2, 'Bread');

INSERT INTO  [Order](CustomerId, OrderDate, OrderAmount) VALUES (1, '12/23/2018', 100);
INSERT INTO  [Order](CustomerId, OrderDate, OrderAmount) VALUES (2, '11/23/2018', 100);
INSERT INTO  [Order](CustomerId, OrderDate, OrderAmount) VALUES (3, '08/23/2018', 100);
INSERT INTO  [Order](CustomerId, OrderDate, OrderAmount) VALUES (3, '08/23/2018', 200);

INSERT INTO  [OrderDetail](OrderId, ItemId, Quantity, Amount) VALUES (1, 1, 10, 50);
INSERT INTO  [OrderDetail](OrderId, ItemId, Quantity, Amount) VALUES (1, 2, 5, 50);
INSERT INTO  [OrderDetail](OrderId, ItemId, Quantity, Amount) VALUES (2, 3, 5, 50);
INSERT INTO  [OrderDetail](OrderId, ItemId, Quantity, Amount) VALUES (3, 3, 5, 50);
INSERT INTO  [OrderDetail](OrderId, ItemId, Quantity, Amount) VALUES (3, 3, 5, 50);
GO