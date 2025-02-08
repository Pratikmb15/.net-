CREATE DATABASE	EMP_DB
use EMP_DB

--CREATE TABLE emp(
--Id int identity(1,1) ,
--Name varchar(50),
--Age int NOT NULL,
--Salary Money
--)

--ALTER TABLE emp ADD  Gender varchar(10);
ALTER table emp
ADD Constraint DF_Salary  Default 20000 for Salary;

UPDATE  emp 
SET Salary = 57000 
where id = 1;

INSERT INTO emp (Name,Age,Gender,Salary,Department) values ('Aryan',32,'Male',49000,'Sales'),('Ria',28,'Female',70000,'IT')

INSERT INTO emp (Name,Age,Gender,Salary) values ('Abishek',25,'Male',55000),('Shreya',21,'Female',45000),('Pratik',22,'Male',52000)

--UPDATE Table emp (Name,Age,Gender) values('Priya',20,'Female') where id =4;
UPDATE  emp 
SET Salary= Default
WHERE Id =5;

SELECT * From emp;

--ALTER TABLE emp
--ADD CONSTRAINT Def_Dept Default 'IT' for Department;

--UPDATE emp 
--SET Department = 'IT' WHERE Department is NULL

--UPDATE emp
--SET Department = 'Sales' WHERE Salary<50000;

SELECT * From emp 
ORDER BY -Salary;

SELECT * From emp
WHERE Salary>50000
ORDER BY -Salary;

select Name,Department from emp
order by Age

SELECT Department, COUNT(Id) AS TotalEmployees, AVG(Salary) AS AvgSalary
FROM emp
GROUP BY Department
order by AvgSalary ;

SELECT * From emp
ORDER BY -Salary
OFFSET 1 ROWS 
FETCH FIRST 4 ROWS ONLY; 

SELECT TOP 3
* FROM EMP
ORDER BY Salary desc;

update emp
set Age = 34 from emp where id =2
update emp
set salary = 52000 from emp where id =1
SELECT TOP 50 percent
* FROM EMP
ORDER BY Salary ;

select distinct Salary,Department,Name from emp

Select * from emp 
where Department ='Sales' AND Salary>40000

Select * from emp 
where Department ='IT' AND Salary>50000
order by Age desc

Select * from emp 
where  (Gender ='Female' or Department = 'Sales') 
and Age<30
order by salary desc;

select * from emp
where Age in (34,22,28)


select * from emp
where Name in 
(
Select Name from emp 
where Gender = 'Female' and Department = 'IT'
)

select * from emp
where Name not in 
(
Select Name from emp 
where Gender = 'Female' or Department = 'IT'
)

Select *from emp
where (age<30 ) and (Salary between 40000 and 70000)

Select * from emp
where Name like 'A%'

Select * from emp
where Name like '%K'

Select * from emp
where Name like '_r%'









TRUNCATE table emp;


