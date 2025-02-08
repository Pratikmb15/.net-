Select * from emp


--create table dbo.Intern(
--Id int Identity(1,1) ,
--Name varchar(50) unique,
--Age int ,
--Stippen Money ,
--Gender varchar(20) ,
--Department varchar(20) Default 'IT'
--)

Select * from Intern
insert into Intern (Name,Age,Stippen,Gender,Department) Values ('Raghav',19,7000,'Male','Marketing'),('Michelle',21,12000,'Female','IT'),('Justin',20,15000,'Male','Managment'),('Robert',22,14000,'Male','IT')

Select * from emp
union
Select * from Intern
order by Department ,salary Desc


Insert into Intern(Name,Age,Stippen,Gender,Department) values('Priya',20,20000,'Female','Sales')
Delete from Intern where Id=7

SET Identity_Insert Intern on 

Insert into intern(Id,Name,Age,Salary,Gender,Department) values (5,'Priya',20,20000,'Female','Sales')

SET Identity_Insert Intern off


Select * from emp
Intersect
Select * from Intern

Select * from emp
Except
Select * from Intern
order by Salary Desc

Select * from Intern
Except
Select * from emp
order by Salary Desc









