create database CTE_DB;
use CTE_DB;

create table Emp(
E_id int,
E_name varchar(50),
E_age int,
E_Department varchar(20),
Dept_id int,
E_Salary money
);

insert into emp(E_id ,E_name ,E_age ,E_Department ,E_Salary,Dept_id ) values (1,'Harry Brook',27,'Sales',35000,107),(2,'Shweta Singh',24,'IT',40000,101),
(3,'Karan Sharma',28,'Finance',42000,105),(4,'John Doe',30,'IT',47000,101),(5,'Jia Dsouza',25,'Sales',38000,107);

select * from Emp;


with AverageSalaryCTE as(
select Dept_id,Avg(E_Salary) as AvgSalary 
from Emp
group by Dept_id
)
--select * from AverageSalaryCTE;
select E.E_id,E.E_name,E.E_Salary,E.E_Department 
from Emp e
join AverageSalaryCTE  as A on E.Dept_id=A.Dept_id
where E.E_Salary>A.AvgSalary;

Create table Departments(Dept_id int PRIMARY KEY,Department_name varchar(20))
insert into Departments(Dept_id,Department_name) VALUES (101,'IT'),(105,'Finance'),(107,'Sales');

alter table Emp
add Location varchar(20)

go
create proc UpdateEmp
@E_id int, @NewLocation varchar(20)
as
begin
Update Emp
set Location = @NewLocation
where E_id=@E_id;
end

EXEC UpdateEmp 1,'Banglore';
EXEC UpdateEmp 2,'Mumbai';
EXEC UpdateEmp 3,'Chennai';
EXEC UpdateEmp 4,'Mumbai';
EXEC UpdateEmp 5,'Hyderabad';



-----INSERT INTO TempEmployees (EmployeeID, EmployeeName, DepartmentID)
Create table TempSalesEmp(EmployeeID int, EmployeeName varchar(50), DepartmentID int,Salary money);
drop table TempSalesEmp;

with SalesTempEmpCTC as(
select E_id,E_name,Dept_id,E_Salary
from Emp
where Dept_id=(Select Dept_id from Departments where Department_name='Sales')
)
Insert into TempSalesEmp(EmployeeID, EmployeeName, DepartmentID,Salary) select E_id,E_name,Dept_id,E_Salary from SalesTempEmpCTC;

select * from TempSalesEmp;

--Increase salaries for employees in  Mumbai-based departments

with MumEmpCTC as(
select E_id from Emp
where Location='Mumbai'
)
update Emp
set E_Salary=E_Salary*1.05
where E_id in(Select E_id from MumEmpCTC);

create table customers( CustomerID int, Name varchar(50));

insert into customers(CustomerID,Name) values (112,'Rehan'),(196,'Shreya'),(127,'Joe'),(119,'Neha'),(134,'Rahul'),(121,'Dev');
insert into customers(CustomerID,Name) values(156,'Riya')

create table Orders(OrderID int, CustomerID int, OrderAmount money, OrderDate Date);

insert into Orders(OrderID, CustomerID, OrderAmount, OrderDate) values(301,112,250,'2025-2-8'),
(302,196,125,'2025-1-30'),(303,112,75,'2025-1-28'),(304,127,50,'2025-2-6')
,(305,119,80,'2025-2-8'),(306,134,500,'2025-2-8'),(307,121,300,'2025-2-8');


With CustomerWithNoOrderCTC as(
select CustomerID from customers
where CustomerID  Not IN(Select distinct CustomerID from Orders)
)
Delete from customers
where CustomerID in(Select CustomerID from CustomerWithNoOrderCTC);