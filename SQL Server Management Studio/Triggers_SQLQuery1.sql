create Database Triggers_DB;

CREATE TABLE Employee(
Emp_id int Primary Key ,
Emp_name Varchar(50) not null,
Emp_salary Decimal(10,2) not null ,
EMp_DOB Datetime not null,
Emp_Experience int not null,
Record_time datetime not null
);

CREATE TABLE Employee_Backup(
Emp_id int  not null ,
Emp_name Varchar(50) not null,
Emp_salary Decimal(10,2) not null ,
EMp_DOB Datetime not null,
Emp_Experience int not null,
Record_time datetime not null
);

CREATE TABLE Employee_History(
Emp_id int NOT NULL,
Field_name varchar(100) NOT NULL,
old_value varchar(100) NOT NULL,
new_value varchar(100) NOT NULL,
record_Time Datetime NOT NULL 
);

--INVALID INPUTS
insert into Employee(Emp_id,Emp_name,Emp_salary,EMp_DOB,Emp_Experience,Record_time)values(10012,'John Doe',52000,'1990-05-15',6,GETDATE());
insert into Employee(Emp_id,Emp_name,Emp_salary,EMp_DOB,Emp_Experience,Record_time)values(10012,'John Doe',52000,'2000-05-15',4,GETDATE());
--VALID INPUT
insert into Employee(Emp_id,Emp_name,Emp_salary,EMp_DOB,Emp_Experience,Record_time)values(10013,'Alex Carry',52000,'2000-07-14',6,GETDATE());

select * from Employee;

update Employee
set Emp_name= 'Charles Brown' where Emp_id=10012;

update Employee
set Emp_salary= 45000 where Emp_id=10012;

select * from Employee;
select * from Employee_History;

delete from Employee
where Emp_id=10012;

select * from Employee;
select * from Employee_Backup;

CREATE TABLE TEST1(
T_ID INT PRIMARY KEY
)

ALTER TABLE TEST1
ADD T_Name varchar(50);

Drop TABLE TEST1;