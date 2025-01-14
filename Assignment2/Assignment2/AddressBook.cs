using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.Versioning;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Contact
    {
     public String FirstName { get; set; }
    public String LastName { get; set; }
    public String Address { get; set; }
    public String City { get; set; }
    public String State { get; set; }
    public String PhoneNo { get; set; }

        public override string ToString()
        {
            return $"Name: {FirstName} {LastName}\nAddress: {Address}, {City}, {State}\nPhone Number: {PhoneNo}\n";
        }



    }
internal class AddressBook
    {
        static List<Contact> addressbook = new List<Contact>();
        public static void Main(String[] args) {
        
           
            bool Status = true;

            while (Status) {
              Console.WriteLine("Enter Any of Below Options:");
              Console.WriteLine("1.Add New Contact \n2.View Contact \n3.Delete \n4.Edit Contact\n5.Exit");
              String op = Console.ReadLine();
                switch (op) {
                    case "1":
                        AddContact();
                        break;
                    case "2":
                        ViewContact();
                        break;
                    case "3":
                        Console.WriteLine("Enter Firstname Of Account to be deleted");
                        String Fname = Console.ReadLine();
                        Delete(Fname);
                        break;
                    case "4":
                        Console.WriteLine("Enter Firstname Of Account to be deleted");
                        String fname = Console.ReadLine();
                        Edit(fname);
                        break;
                    case "5":
                        return;
                    
                    default:
                        Console.WriteLine("Enter Valid Option !");
                        break;
                }
            }
        }
       public  static void AddContact() {
            Console.WriteLine("Enter First Name:");
            string Fname= Console.ReadLine();

            Console.WriteLine("Enter Last Name:");
            string Lname = Console.ReadLine();

            Console.WriteLine("Enter Address:");
            string address = Console.ReadLine();

            Console.WriteLine("Enter City:");
            string city = Console.ReadLine();

            Console.WriteLine("Enter State:");
            string state = Console.ReadLine();

            Console.WriteLine("Enter Phone Number :");
            string phonenum = Console.ReadLine();

            Contact Newcontact = new Contact
            {
                FirstName =Fname,
                LastName=Lname,
                Address=address,
                City=city,
                State=state,
                PhoneNo=phonenum
            };
            addressbook.Add(Newcontact);
            Console.WriteLine("Contact Added Successfully !");



        }
        public static void ViewContact()
        {
            if (addressbook.Count == 0) {
                Console.WriteLine("There Are no Contacts in AddressBook");
                return;
            }
            foreach (Contact items in addressbook) {
                Console.WriteLine(items);
            }

        }
         public static void Delete(string firstName)
        {
            Contact foundContact = addressbook.Find(c => c.FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase));
            if (foundContact == null)
            {
                Console.WriteLine("Contact Not Found!");
                return;
            }

            addressbook.Remove(foundContact);
            Console.WriteLine("Contact Deleted Successfully!");
        }
        public static void Edit(String firstName) {
            Contact FoundContact = addressbook.Find(c => c.FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase));
            if (FoundContact == null) {
                Console.WriteLine("Contact To be Deleted not Found!");
                return;
            }
            Console.WriteLine("Enter Parameter to be Edited :");
            String parameter = Console.ReadLine();

            switch(parameter){

                case "FirstName":
                    Console.WriteLine("Enter First Name:");
                    string Fname = Console.ReadLine();
                    FoundContact.FirstName = Fname;
                    break;

                case "LastName":
                    Console.WriteLine("Enter Last Name:");
                    string Lname = Console.ReadLine();
                    FoundContact.LastName = Lname;
                    break;


                case "Address":
                    Console.WriteLine("Enter Address:");
                    string address = Console.ReadLine();
                    FoundContact.Address = address;
                    break;

                case "City":
                    Console.WriteLine("Enter City:");
                    string city = Console.ReadLine();
                    FoundContact.City = city;
                    break;

                case "State":
                    Console.WriteLine("Enter Stae:");
                    string state = Console.ReadLine();
                    FoundContact.State = state;
                    break;

                case "PhoneNo":
                    Console.WriteLine("Enter Phone Number :");
                    string phonenum = Console.ReadLine();
                    FoundContact.PhoneNo = phonenum;
                    break;

                default:
                    Console.WriteLine("Enter Valid Option !");
                    break;
                }
            
        }
    }
   
}

