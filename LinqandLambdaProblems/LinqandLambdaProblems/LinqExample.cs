using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqandLambdaProblems
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public String JobProfile { get; set; }
    }
    internal class LinqExample
    {
        public static void Main()
        {
            var NEmloyees = getEmployees();


            var WebdevEmployees = (NEmloyees.Where(x => x.JobProfile == "Web Developer"));
            Console.WriteLine("Web Developer Employees are:");
            foreach (var Emp in WebdevEmployees)
            {
                Console.WriteLine($"Employee Id = {Emp.Id}  Name : {Emp.Name} Salary : {Emp.Salary} Job Profile = {Emp.JobProfile}");
            }

            var DataAnalyst = (from emp in LinqExample.getEmployees() where emp.JobProfile == "Data Analyst" select emp).ToList();
            Console.WriteLine("Data Analyst Employees are:");
            foreach (var emp in DataAnalyst)
            {
                Console.WriteLine($"Employee Id = {emp.Id}  Name : {emp.Name} Salary : {emp.Salary} Job Profile = {emp.JobProfile}");
            }

        }
        public static List<Employee> getEmployees()
        {
            List<Employee> employees = new List<Employee>() {
        new Employee{Id=20211, Name="Samay", Salary= 35000, JobProfile= "Web Developer"},
        new Employee{Id=20213, Name="Ajit", Salary= 28000, JobProfile= "Data Analyst"},
        new Employee{Id=20217, Name="Ragini", Salary= 42000, JobProfile= "HR"},
        new Employee{Id=20222, Name="Gia", Salary= 45000, JobProfile= "Marketing Head"},
        new Employee{Id=20232, Name="Akruti", Salary= 35000, JobProfile= "Data Analyst"},
        new Employee{Id=20233, Name="Kartik", Salary= 55000, JobProfile= "Web Developer"}

        };
            return employees;

        }

    }
}
