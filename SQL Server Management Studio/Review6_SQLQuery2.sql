--Create two tables: Customers (CustomerID, Name) and Orders (OrderID, CustomerID, OrderDate, Amount).

insert into customers(CustomerID,Name) values (112,'Rehan'),(196,'Shreya'),(127,'Joe'),(119,'Neha'),(134,'Rahul'),(121,'Dev');

select * from customers;
select * from Orders;

select customers.CustomerID,customers.Name as customer_name ,Orders.OrderID,Orders.OrderAmount,Orders.OrderAmount
from customers
inner join Orders on customers.CustomerID=Orders.CustomerID;


--Create two tables: Employees (EmployeeID, Name) and Projects (ProjectID, EmployeeID, ProjectName).

create table Projects(ProjectID int , E_iD int , ProjectName varchar(50)) ;

insert into Projects(ProjectID, E_iD, ProjectName) values (101, 1, 'Sales Performance Dashboard'),
(102, 2, 'IT Infrastructure Upgrade'),(103, 3, 'Financial Forecasting Model'),(101,5,'Sales Performance Dashboard');

select * from Emp;
select * from Projects;

select Projects.ProjectID,Projects.ProjectName,Emp.E_name,Emp.E_Department
from Emp
right join  Projects on Emp.E_iD=Projects.E_iD;

