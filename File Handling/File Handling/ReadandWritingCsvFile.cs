using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
using CsvHelper.Configuration.Attributes;
using CsvHelper;
using System.Globalization;

namespace File_Handling
{
    // Index User Id First Name Last Name  Email Phone   Date of birth Job Title

    public class People
    {
        [Name("Index")]
        public int Index { get; set; }

        [Name("User Id")]
        public string UserId { get; set; }

        [Name("First Name")]
        public string FirstName { get; set; }

        [Name("Last Name")]
        public string LastName { get; set; }

        [Name("Sex")]
        public string Sex { get; set; }

        [Name("Email")]
        public string Email { get; set; }

        [Name("Phone")]
        public string Phone { get; set; }

        [Name("Date of birth")]
        public DateTime DateOfBirth { get; set; }

        [Name("Job Title")]
        public string JobTitle { get; set; }


    }
    internal class ReadandWritingCsvFile
    {
        public static void Main(string[] args)
        {
            string inputFile = @"C:\Users\MILIND\Downloads\people-100.csv";
            string outputFile = @"C:\Users\MILIND\Downloads\Filteredpeople.csv";

            List<People> OutputRecords = new();

            using (var reader = new StreamReader(inputFile))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture)) {

                var records = csv.GetRecords<People>();
                foreach (var rec in records) {
                    if (rec.FirstName.StartsWith('B')) {
                    OutputRecords.Add(rec);
                    }
                    Console.WriteLine("{0} {1}",rec.FirstName,rec.LastName);
                }
            
            }
            Console.WriteLine(OutputRecords.Count);

            using (var writer = new StreamWriter(outputFile))
            using (var csvOut = new CsvWriter(writer,CultureInfo.InvariantCulture)) {
                csvOut.WriteRecords(OutputRecords);
            }
           


        }
    }
}
