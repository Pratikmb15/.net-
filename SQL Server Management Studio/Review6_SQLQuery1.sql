Create database Review_6;

create table Emp(
E_id int,
E_name varchar(50),
E_age int,
E_Department varchar(20),
E_Salary money
);

insert into emp(E_id ,E_name ,E_age ,E_Department ,E_Salary ) values (1,'Harry Brook',27,'Sales',35000),(2,'Shweta Singh',24,'IT',40000),
(3,'Karan Sharma',28,'Finance',42000),(4,'John Doe',30,'IT',47000),(5,'Jia Dsouza',25,'Sales',38000);

Update Emp set E_Salary=50000 where E_id=3;

delete from Emp where E_name='John Doe';

select * from Emp;

create table Students(
S_id int identity(1,1),
S_name varchar(50),
S_class varchar(20),
S_DOB date,
S_grade int 
)

ALter table students
Alter Column S_grade varchar(3);


insert into students(S_name ,S_class,S_DOB ,S_grade)values('Abhishek Sharma','9th','2008-1-12','B'),
('Sanjana Dixit','8th','2009-11-3','A'),('Rajiv Gupta','10th','2007-1-12','C'),('Neha Deshpande','8th','2009-12-27','B')
,('Karan Singh','9th','2008-5-17','A'),('Sanya Khan','7th','2010-3-22','C'),('Pooja kadam','9th','2008-10-22','B'),
('Kunal Jadhav','8th','2009-1-8','A'),('Rehan Shaikh','10th','2007-5-15','B'),('Sakshi Patel','9th','2008-9-9','A');

select * from students;

update Students set S_grade = 'B' where S_id=5;

Delete from Students where S_class='10th';

--Create a Products table with columns: ProductID, ProductName, Price, Stock.
create table Products(
ProductID int,
ProductName varchar(30), 
Price money,
Stock int
)

insert into Products(ProductID, ProductName, Price, Stock) values(101,'Brown Bread',30,20),(105,'Milk',60,30),(230,'Dates',300,4),(107,'Potato Chips',10,40),
(106,'Orange Juice',50,10),(112,'Biscuits',30,20),(225,'Almonds',400,10),(227,'Cashew',420,15);

Select * from Products;

update products
set Price= price*1.10;

delete from Products
where Stock<5;

CREATE TABLE Users (
    UserID INT PRIMARY KEY,            
    Username VARCHAR(50) NOT NULL,     
    Email VARCHAR(100) UNIQUE, 
    Password VARCHAR(50) NOT NULL       
    CHECK (len(Password) >= 8)   )       

INSERT INTO USERS (UserID, Username, Email,Password) VALUES(101,'John Doe','johndoe1@gmail.com','john@123');

--Invalid 
INSERT INTO USERS (UserID, Username, Email,Password) VALUES(101,'Ajay Sharma','ajay21@gmail.com','ajay@123');
INSERT INTO USERS (UserID, Username, Email,Password) VALUES(102,'Ajay Sharma','johndoe1@gmail.com','ajay@123');
INSERT INTO USERS (UserID, Username, Email,Password) VALUES(102,'Ajay Sharma','ajay21@gmail.com','aj3');

--valid
INSERT INTO USERS (UserID, Username, Email,Password) VALUES(102,'Ajay Sharma','ajay21@gmail.com','ajay@123');


select * from Emp;

Create table Department(Department_Id int Primary key ,E_Department varchar(30));
insert into Department(Department_Id,E_Department) values(201,'IT'),(205,'Finance'),(210,'Sales');

alter table Emp
add Department_Id int;

alter table Emp
add Constraint FK_Department_Id foreign key(Department_Id) References Department(Department_Id)

insert into emp(E_id ,E_name ,E_age ,E_Department ,E_Salary,Department_Id ) values (11,'Shawn Marsh',24,'Sales',34000,222);
insert into emp(E_id ,E_name ,E_age ,E_Department ,E_Salary,Department_Id ) values (11,'Shawn Marsh',24,'Sales',34000,210);

alter table products
add constraint chk_price check(price>0); 

insert into Products(ProductID, ProductName, Price, Stock) values(121,'Led bulb',0,20);
insert into Products(ProductID, ProductName, Price, Stock) values(121,'Led bulb',120,20);

--Create a Customers table with columns: CustomerID, Name, and Phone.
create table customers( CustomerID int, Name varchar(50), Phone varchar(12));

exec sp_rename 'customers.phone', 'ContactNumber','column';
select * from  customers;

alter table customers
alter column ContactNumber char(15) ;

select * from Emp where E_Salary >40000;

select * from Emp;

select * from Emp where E_age>25 and E_age<28;

--Create an Orders table with columns: OrderID, CustomerID, OrderAmount, OrderDate
create table Orders(OrderID int, CustomerID int, OrderAmount money, OrderDate Date);

insert into Orders(OrderID, CustomerID, OrderAmount, OrderDate) values(301,112,250,'2025-2-8'),
(302,196,125,'2025-1-30'),(303,112,75,'2025-1-28'),(304,127,50,'2025-2-6')
,(305,119,80,'2025-2-8'),(306,134,500,'2025-2-8'),(307,121,300,'2025-2-8');

select * from Orders
order by OrderAmount desc;

select top 5 * from Orders
order by OrderDate desc;











