using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqandLambdaProblems
{
    internal class Linq3
    {
        class Employee
        {
            public int Id { get; set; }
            public String Name { get; set; }
            public int Age { get; set; }
            public DateTime DateofJoining { get; set; }
            public double Salary { get; set; }
            public String Department { get; set; }
        }
        public static void Main(String[] args)
        {
            try
            {
                List<Employee> Employees = new List<Employee>() { new Employee{Id=20211,Name="Prathamesh",Age=23,DateofJoining=new DateTime(2025,01,01),Salary= 35000, Department="Sales"},
            new Employee{Id=20212,Name="Sayli",Age=26, DateofJoining=new DateTime(2024,06,01),Salary= 55000, Department="IT"},
            new Employee{Id=20213,Name="Atharva",Age=23, DateofJoining=new DateTime(2024,06,01),Salary= 48000,Department = "R&D" },
            new Employee{Id=20214,Name="Vaishnavi",Age=24,DateofJoining=new DateTime(2024,11,01),Salary= 40000, Department = "Sales" },
            new Employee{Id=20217,Name="Pradnya",Age=23, DateofJoining=new DateTime(2024,03,01),Salary= 52000, Department = "IT" }
            };


                //var groupedEmployeesbyAge = Employees.GroupBy(x => x.Age);
                //Console.WriteLine("Employees in Groups are :");
                //foreach (var grp in groupedEmployeesbyAge)
                //{
                //    Console.WriteLine($"\nAge: {grp.Key}");
                //    foreach (var emp in grp)
                //    {
                //        Console.WriteLine($" - Name: {emp.Name}");
                //    }
                //}
                DateTime target = new DateTime(2024, 05, 31);
                var Employeesjoionedafterjune2024 = Employees.Where(x => x.DateofJoining > target).OrderBy(x => x.DateofJoining);
                Console.WriteLine("Employees who have joined After 31-05-2024 are :");
                foreach (var i in Employeesjoionedafterjune2024)
                {
                    Console.WriteLine($"DOJ = {i.DateofJoining.ToString("yyyy-MM-dd")}  Id = {i.Id} Name = {i.Name} Age = {i.Age} Salary = {i.Salary}");
                }

                var groupedEmployeesbyDepartment = Employees.GroupBy(x => x.Department);
                Console.WriteLine("\nEmployees After Grouped into Departments :");
                foreach (var group in groupedEmployeesbyDepartment)
                {
                    Console.WriteLine($"\nEmployees in {group.Key} Department are :");
                    foreach (var e in group)
                    {
                        Console.WriteLine($"- Name= {e.Name}   DOJ = {e.DateofJoining.ToString("yyyy-MM-dd")} Salary = {e.Salary}");
                    }
                    Console.WriteLine();
                }

                foreach (var group in groupedEmployeesbyDepartment)
                {
                    Double avgSalaryinDepartment = group.Average(x => x.Salary);
                    Console.WriteLine($"Average Salary in {group.Key} Department is {avgSalaryinDepartment}");
                }

                var top3HighestSalariedEmployee = Employees.OrderByDescending(x => x.Salary).Take(3);
                Console.WriteLine("\nTop 3 Employees Having Highest Salary are :");
                foreach (var item in top3HighestSalariedEmployee)
                {
                    Console.WriteLine($"Name = {item.Name} Age = {item.Age} Department = {item.Department} Salary = {item.Salary}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
