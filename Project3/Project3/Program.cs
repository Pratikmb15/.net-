using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;

namespace Project3
{
    public class Program
    {
        private static RestClient client = new RestClient("http://localhost:3000");

        static async Task Main(string[] args)
        {
            try
            {
                Console.WriteLine("Getting employee list...");
                await GetEmployeeList();

                //Console.WriteLine("Adding a new employee...");
                //await AddNewEmployee("6", "Maxwell", "70000");

                //Console.WriteLine("Updating employee salary...");
                //await UpdateEmployeeSalary("1", "90000");

                //Console.WriteLine("Deleting an employee...");
                //await DeleteEmployee(5);

                //Console.WriteLine("Adding multiple Employees...");
                //await AddMultipleEmployees();

                Console.WriteLine("All operations completed.");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }

        private static async Task GetEmployeeList()
        {
            var request = new RestRequest("Employees", Method.Get);
            var response = await client.ExecuteAsync(request);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                Console.WriteLine($"Raw JSON Response: {response.Content}"); // Debugging
                List<Employee> employeeList = JsonConvert.DeserializeObject<List<Employee>>(response.Content);
                foreach (var emp in employeeList)
                {
                    Console.WriteLine($"Id: {emp.Id}, Name: {emp.Name}, Salary: {emp.Salary}");
                }
            }
            else
            {
                Console.WriteLine($"Failed to get employee list. Status: {response.StatusCode}");
            }
        }

        private static async Task AddNewEmployee(string id, string name, string salary)
        {
            var request = new RestRequest("Employees", Method.Post);
            var jsonObj = new { id, name, salary };
            request.AddJsonBody(jsonObj);

            var response = await client.ExecuteAsync(request);

            if (response.StatusCode == HttpStatusCode.Created)
            {
                Console.WriteLine($"Added Employee: {name}, Salary: {salary}");
            }
            else
            {
                Console.WriteLine($"Failed to add employee. Status: {response.StatusCode}");
            }
        }

        private static async Task AddMultipleEmployees()
        {
            var employees = new List<Employee>
            {
                new Employee { Name = "Dustin", Salary = "85536" },
                new Employee { Name = "Will", Salary = "120123" },
                new Employee { Name = "Eleven", Salary = "123456" }
            };

            foreach (var emp in employees)
            {
                var request = new RestRequest("Employees", Method.Post);
                var jsonObj = new
                {
                    name = emp.Name,
                    salary = emp.Salary
                };

                request.AddJsonBody(jsonObj);

                var response = await client.ExecuteAsync(request);

                if (response.StatusCode == System.Net.HttpStatusCode.Created)
                {
                    var addedEmp = JsonConvert.DeserializeObject<Employee>(response.Content);
                    Console.WriteLine($"Added Employee: {addedEmp.Name}, Salary: {addedEmp.Salary}");
                }
                else
                {
                    Console.WriteLine($"Failed to add employee {emp.Name}. Status: {response.StatusCode}");
                }
            }
        }

        private static async Task UpdateEmployeeSalary(string id, string newSalary)
        {
            var request = new RestRequest($"Employees/{id}", Method.Put);
            var jsonObj = new { salary = newSalary };
            request.AddJsonBody(jsonObj);

            var response = await client.ExecuteAsync(request);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                Console.WriteLine($"Updated Employee ID {id} with new salary: {newSalary}");
            }
            else
            {
                Console.WriteLine($"Failed to update employee salary. Status: {response.StatusCode}");
            }
        }

        private static async Task DeleteEmployee(int id)
        {
            var request = new RestRequest($"Employees/{id}", Method.Delete);
            var response = await client.ExecuteAsync(request);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                Console.WriteLine($"Successfully deleted employee with ID: {id}");
            }
            else
            {
                Console.WriteLine($"Failed to delete employee. Status: {response.StatusCode}");
            }
        }
    }


}
