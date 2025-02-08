select * from emp;
select * from intern;

create table tempEmp(
Empid int,
E_Name varchar(50),
E_Age int,
E_Salary Money,
E_Gender varchar(10),
E_Department varchar(20)
)


select * from emp where salary>(select AVG(Salary) from emp)
order by Salary;

Insert into tempEmp
(Empid,E_Name,E_Age ,E_Salary ,E_Gender ,E_Department )
select emp.Id,emp.Name,emp.Age,emp.Salary,emp.Gender,emp.Department
from emp
where Department='IT';

--delete from tempEmp
--where E_Department= 'IT'


select * from tempEmp;

update tempEmp
set E_Salary= (select AVG(E_Salary) from tempEmp where E_Department='Sales') where E_Department='Sales';

update tempEmp
set E_Salary= (select AVG(E_Salary) from tempEmp where E_Department='IT') where E_Department='IT';

