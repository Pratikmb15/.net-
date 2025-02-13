CREATE DATABASE SalesDB;
USE SalesDB;

CREATE TABLE Customers (
    CustomerID INT PRIMARY KEY,
    CustomerName VARCHAR(100),
    City VARCHAR(50)
);

CREATE TABLE Products (
    ProductID INT PRIMARY KEY,
    ProductName VARCHAR(100),
    Price DECIMAL(10, 2)
);

CREATE TABLE Orders (
    OrderID INT PRIMARY KEY,
    CustomerID INT,
    OrderDate DATE,
    FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID)
);

CREATE TABLE OrderItems (
    OrderItemID INT PRIMARY KEY,
    OrderID INT,
    ProductID INT,
    Quantity INT,
    FOREIGN KEY (OrderID) REFERENCES Orders(OrderID),
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID)
);

CREATE TABLE Shipping (
    ShippingID INT PRIMARY KEY,
    OrderID INT,
    ShippingDate DATE,
    ShippingStatus VARCHAR(50),
    FOREIGN KEY (OrderID) REFERENCES Orders(OrderID)
);

INSERT INTO Customers (CustomerID, CustomerName, City) VALUES
(1, 'Alice Johnson', 'New York'),
(2, 'Bob Smith', 'Los Angeles'),
(3, 'Charlie Brown', 'Chicago'),
(4, 'David Williams', 'Houston');

INSERT INTO Products (ProductID, ProductName, Price) VALUES
(1, 'Laptop', 80000.00),
(2, 'Smartphone', 50000.00),
(3, 'Headphones', 2000.00),
(4, 'Smartwatch', 15000.00);

INSERT INTO Orders (OrderID, CustomerID, OrderDate) VALUES
(101, 1, '2025-02-12'),
(102, 2, '2025-05-28'),
(103, 3, '2025-02-23');

INSERT INTO OrderItems (OrderItemID, OrderID, ProductID, Quantity) VALUES
(1, 101, 1, 1),
(2, 101, 3, 2),
(3, 102, 2, 1),
(4, 102, 4, 1),
(5, 103, 3, 5);

INSERT INTO Shipping (ShippingID, OrderID, ShippingDate, ShippingStatus) VALUES
(1, 101, '2025-02-14', 'Delivered'),
(2, 102, '2025-06-02', 'In Transit'),
(3, 103, '2025-02-25', 'Pending');

SELECT * FROM Customers;
SELECT * FROM Products;
SELECT * FROM Orders;
SELECT * FROM OrderItems;
SELECT * FROM Shipping;

--Write an SQL query to get Customer Name, Order ID, Order Date, Product Name, and Total Price
select CustomerName, o.OrderID, OrderDate, ProductName, (p.Price*i.Quantity) as TotalPrice
from  Orders as o 
inner join  Customers as c on c.CustomerID=o.CustomerID
inner join OrderItems as i on o.OrderId=i.OrderId
inner join Products as p on i.ProductID = p.ProductID
order by OrderDate;

-- List All Customers and Their Orders (Including Those Who Haven’t Ordered)
Select CustomerName,o.OrderID,OrderDate,ProductName,Price
from  Orders as o 
Right join  Customers as c on c.CustomerID=o.CustomerID
Left join OrderItems as i on o.OrderId=i.OrderId
Left join Products as p on i.ProductID = p.ProductID
order by OrderDate;

--Get all orders with Product Name, Quantity, Order Date, Shipping Date, and Shipping Status. 
--Include only shipped orders.
select ProductName, Quantity, OrderDate, ShippingDate,ShippingStatus 
from Orders as o
inner join OrderItems as i on o.OrderID=i.OrderID
inner join Products as p on i.ProductID=p.ProductID
inner join Shipping as s on i.OrderID = s.OrderID
where ShippingStatus is not null;

--Find and delete Customers Who Have Not Placed Any Orders
select Customers.CustomerID,CustomerName,City
from Customers
left join Orders on Customers.CustomerID=Orders.CustomerID
where OrderID is Null;

Delete from Customers where CustomerID=(select Customers.CustomerID
from Customers
left join Orders on Customers.CustomerID=Orders.CustomerID
where OrderID is Null);



