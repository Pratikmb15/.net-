using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqandLambdaProblems
{
    public class Student
    {
        public int Rollno { get; set; }
        public string Name { get; set; }

        public int Marks { get; set; }
    }
    internal class LambdaExpressionExmp
    {
        public static void Main()
        {
            List<Student> Students = new List<Student>() { new Student {Rollno =01 ,Name="Rahul",Marks=79 },
            new Student{ Rollno = 02, Name = "Shalini", Marks=87 },
            new Student{Rollno =03 ,Name="Surbhi", Marks=78},
            new Student{Rollno =04 ,Name="Aryan", Marks=65},
            new Student{Rollno =05 ,Name="Abhishek", Marks=83},
            new Student{Rollno =06 ,Name="Aditi", Marks=92},
            new Student{Rollno =07 ,Name="Siddhi", Marks=72}
           };

            var StudentDetails = Students.OrderByDescending(x => x.Marks);

            foreach (var ele in StudentDetails)
            {
                Console.WriteLine($" Roll number: {ele.Rollno} Name : {ele.Name} Marks = {ele.Marks}");
            }
            Console.WriteLine();
            var Studentroll2 = Students.Find(x => x.Rollno == 02);
            Console.WriteLine($" Roll number: {Studentroll2.Rollno} Name : {Studentroll2.Name} Marks ={Studentroll2.Marks}");

            var StudentWithDistinction = (Students.FindAll(x => x.Marks >= 75)).OrderByDescending(y => y.Marks);
            Console.WriteLine("\nStudent With Distinction Are :");
            foreach (var stdnt in StudentWithDistinction)
            {
                Console.WriteLine($" Roll number: {stdnt.Rollno} Name : {stdnt.Name} Marks = {stdnt.Marks}");
            }

            Student FirstStudenttoGetDistinction = Students.First(z => z.Marks > 75);
            Console.WriteLine("\nFirst Student Rollno. Wise To get Distinction in test");
            Console.WriteLine($"Roll number: {FirstStudenttoGetDistinction.Rollno} Name : {FirstStudenttoGetDistinction.Name} Marks = {FirstStudenttoGetDistinction.Marks} ");
            Console.WriteLine("\nStudents with Marks Updated to 83:");
            var updatedMarks = Students.Select(x =>
            {
                x.Marks = 83;
                return x;
            });

            foreach (var student in updatedMarks)
            {
                Console.WriteLine($"Roll number: {student.Rollno}, Name: {student.Name}, Marks: {student.Marks}");
            }
        }

    }
}
