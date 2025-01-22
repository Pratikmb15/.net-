using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using System.Runtime.CompilerServices;

namespace File_Handling
{
    internal class Demojson
    {
        public class Student
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Department { get; set; }
        }

        public static void Main(string[] args)
        {
            string path = @"C:\Users\MILIND\source\repos\File Handling\File Handling\Demo2.json";

            var records = new List<Student>
            {
                new Student { Id = 8, Name = "XYZ", Department = "Mechanical" },
                new Student { Id = 1, Name = "ABC", Department = "Computer" },
                new Student { Id = 26, Name = "KFQ", Department = "EXTC" },
                new Student { Id = 15, Name = "QSR", Department = "IT" }
            };

            // Serialize the list of students to a JSON string
            string jsonString = JsonConvert.SerializeObject(records, Formatting.Indented);

            // Write the JSON string to a file
            File.WriteAllText(path, jsonString);

            Console.WriteLine("Data has been written to the file successfully.");

            // Read the JSON string from the file
            string readedJsonString = File.ReadAllText(path);

            var readedRecords = JsonConvert.DeserializeObject<List<Student>>(readedJsonString);
            foreach (Student st in readedRecords) {
            Console.WriteLine($"Id : {st.Id}, Name : {st.Name}, Department : {st.Department}");
            }
        }
    }
}
