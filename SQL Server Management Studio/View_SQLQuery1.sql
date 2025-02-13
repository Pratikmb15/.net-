create database view_DB;
use view_DB;
CREATE DATABASE view_DB;
USE view_DB;

CREATE TABLE Products(
    Product_id INT PRIMARY KEY,
    Product_name VARCHAR(50),
    Product_Price DECIMAL(10,2)
);

CREATE TABLE Orders(
    Order_id INT PRIMARY KEY,
    Order_date DATE,
    Customer_name VARCHAR(50)
);


CREATE TABLE Order_items(
    Order_items_id INT PRIMARY KEY,
    Order_id INT,
    Product_id INT,
    Quantity INT,
    Product_Price DECIMAL(10,2),  -- Price at the time of order
    FOREIGN KEY (Order_id) REFERENCES Orders(Order_id),
    FOREIGN KEY (Product_id) REFERENCES Products(Product_id)
);

INSERT INTO Products(Product_id, Product_name, Product_Price) 
VALUES 
(1, 'Laptop', 80000.00),
(2, 'Smartphone', 50000.00),
(3, 'Headphones', 2000.00),
(4, 'Smartwatch', 15000.00);

INSERT INTO Orders(Order_id, Order_date, Customer_name)
VALUES
(101, '2025-02-12', 'Alice Johnson'),
(102, '2025-05-28', 'Bob Smith'),
(103, '2025-02-23', 'Charlie Brown');

INSERT INTO Order_items(Order_items_id, Order_id, Product_id, Quantity, Product_Price) 
VALUES
(1, 101, 1, 1, 80000.00),   
(2, 101, 3, 2, 2000.00),   
(3, 102, 2, 1, 50000.00),   
(4, 102, 4, 1, 15000.00),   
(5, 103, 3, 5, 2000.00);   

select * from Products;
select * from Orders;
select * from Order_items;
go


create view Daily_sales
as
select 
o.order_id,YEAR(Order_date) as Y,MONTH(Order_date) as M,DAY(Order_date) as D,Quantity*i.Product_Price as Total_Price
from Orders as o
inner join Order_items as i on o.Order_id=i.Order_id
inner join Products as p on i.Product_id=p.Product_id;

Alter view Daily_sales
as
select 
o.order_id,Order_date,O.Customer_name,P.Product_name,P.Product_Price,i.Quantity,Quantity*i.Product_Price as Total_Price
from Orders as o
inner join Order_items as i on o.Order_id=i.Order_id
inner join Products as p on i.Product_id=p.Product_id;


Select * from Daily_sales
order by Order_date;

drop view Daily_sales





