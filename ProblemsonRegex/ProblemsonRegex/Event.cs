using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace ProblemsonRegex
{
    //Create a model Document with:
    //FileName: Required, must be a string ending with.pdf or.docx.
    //FileSize: Must be between 1 KB and 5 MB.Validate the fields and restrict unsupported formats or file sizes.

    public class Document {
        [Required(ErrorMessage = "FileName is Required")]
        [RegularExpression(@".*\.(pdf|docx)$", ErrorMessage = "FileName must end with .pdf or .docx")]
        public String FileName { get; set; }

        [Range(1024, 5242880, ErrorMessage = "FileSize must be between 1 KB and 5 MB")]
        public long FileSize { get; set; }
    }
    public class Participants {
        [Required(ErrorMessage ="Name is Required")]
        [MaxLength(30,ErrorMessage ="Maximum Length of Name can be 30")]
        public String Name { get; set; }
        [Range(18,60,ErrorMessage ="Age must be between 18 and 60")]
        public int Age { get; set; }
        [Phone(ErrorMessage ="Enter Valid PhoneNumber")]
        public String Phonenum { get; set; }

    }
    internal class Event
    {
        public static void Main(String[] args) {
            Console.WriteLine("Enter Participants Details ");
            Console.Write("Enter Name :");
            String name = Console.ReadLine();
            Console.Write("Enter Age :");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter PhoneNumber :");
            String phonenum = Console.ReadLine();

            Participants participant = new Participants()
            {
                Name = name,
                Age = age,
                Phonenum = phonenum
            };
            var context = new ValidationContext(participant);
            var results = new List<ValidationResult>();
            var isValid = Validator.TryValidateObject(participant, context, results, true);
            if (isValid)
            {
                Console.WriteLine("Participant Details are Valid");
            }
            else {
                foreach (var error in results) {
                    Console.WriteLine(error.ErrorMessage);
                }
            
            }

            Console.Write("Enter FileName :");
            String filename = Console.ReadLine();
            Console.Write("Enter FileSize :");
            long filesize = long.Parse(Console.ReadLine());

            Document newDoc = new Document()
            {
                FileName=filename,
                FileSize = filesize
            };

            var context2 = new ValidationContext(newDoc);
            var result2 = new List<ValidationResult>();

            var isValidDoc = Validator.TryValidateObject(newDoc, context2, result2, true);  

            if(isValidDoc)
            {
                Console.WriteLine("Document Details are Valid");
            }
            else
            {
                foreach (var error in result2)
                {
                    Console.WriteLine(error.ErrorMessage);
                }
            }
        }
    }
}
