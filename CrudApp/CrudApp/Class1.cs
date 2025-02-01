using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudApp
{
    internal class Class1
    {
        public static void Main(String[] args)
        {

            SqlConnection sqlConnection;

            try
            {
                bool iBool = true;
                while (iBool)
                {
                    Console.WriteLine("Choose any one option from below -\n1.Create \n2.Retrieve \n3.Update \n4.Delete \n5 Exit ");
                    int op = int.Parse(Console.ReadLine());


                String connectionString = @"Data Source=LAPTOP-FA5GMPCP\SQLEXPRESS;Initial Catalog=CoDb;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
                sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
              
              
                    switch (op)
                    {

                        case 1:
                            Console.Write("\nEnter your name :");
                            String name = Console.ReadLine();
                            Console.WriteLine("Enter your age :");
                            int age = int.Parse(Console.ReadLine());
                            String insertQuery = "INSERT INTO Details(user_name,user_age) VALUES('" + name + "'," + age + ")";
                            SqlCommand insertCommand = new SqlCommand(insertQuery, sqlConnection);
                            insertCommand.ExecuteNonQuery();
                            Console.WriteLine("Data Inserted Successfully");
                            break;

                        case 2:
                            //Retrieve the data
                            String displayQuery = "SELECT * FROM Details";
                            SqlCommand displayCommand = new SqlCommand(displayQuery, sqlConnection);
                            SqlDataReader dataReader = displayCommand.ExecuteReader();
                            while (dataReader.Read())
                            {
                                Console.WriteLine("User Id : " + dataReader.GetValue(0));
                                Console.WriteLine("User Name : " + dataReader.GetValue(1));
                                Console.WriteLine("User Age : " + dataReader.GetValue(2));
                                Console.WriteLine();
                            }
                            dataReader.Close();
                            break;

                        case 3:

                            //Update the data
                            Console.Write("Enter the id of user to be updated : ");
                            int id = int.Parse(Console.ReadLine());
                            Console.Write("Enter the new name : ");
                            String u_name = Console.ReadLine();
                            String updateQuery = "UPDATE Details SET user_name='" + u_name + "' WHERE user_id=" + id + "";
                            SqlCommand updateCommand = new SqlCommand(updateQuery, sqlConnection);
                            updateCommand.ExecuteNonQuery();
                            Console.WriteLine("Data updated successfully ");
                            break;

                        case 4:

                            //Delete the data
                            Console.Write("Enter the id of user to be deleted : ");
                            int del_id = int.Parse(Console.ReadLine());
                            String deleteQuery = "DELETE FROM Details WHERE user_id = " + del_id + "";
                            SqlCommand deleteCommand = new SqlCommand(deleteQuery, sqlConnection);
                            deleteCommand.ExecuteNonQuery();
                            Console.WriteLine("Data deleted successfully ");
                            break;

                        case 5:
                            Console.WriteLine("Exited Successfully ");
                            Environment.Exit(0);
                            iBool = false;
                         sqlConnection.Close();
                            break;
                        default:
                            Console.WriteLine("Invalid Option");
                            break;
                    }

                }

                }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        } 
    }
}
