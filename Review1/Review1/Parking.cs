using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace Review1
{
    internal class Parking
    {
        int ParkingCapacity;
        int ParkingOccupied = 0;
        String ParkingStatus = "Vacant";

        

        public Parking(int Capacity) 
        { 
            this.ParkingCapacity = Capacity;
        }

        public void ParkNewcar()
        {
            if (IsFull())
            {
                ParkingStatus = "Full";
                Console.WriteLine("Parking is Full !");
            }
            else
            { 
                ParkingOccupied++;
                Console.WriteLine("Parking Alloted Succesfully!");
            }
        }
        public void RemoveCar()
        {
            if (ParkingOccupied == 0)
            {
                Console.WriteLine("Parking is Empty!");
            }
            else
            { 
                ParkingOccupied--;
                Console.WriteLine("Car Removed from Parking Succesfully");
            }
        }
        public bool IsFull() {
            return ParkingOccupied == ParkingCapacity;
        }
        public void Display() {
            Console.WriteLine($"Current Parking Status is : {ParkingOccupied}/{ParkingCapacity} ");
        }

        public static void Main(string[] args)
        {
            Parking NewParking = new Parking(100);
            NewParking.Display();
            NewParking.ParkNewcar();
            NewParking.ParkNewcar();
            NewParking.ParkNewcar();
            NewParking.ParkNewcar();


            NewParking.Display();


        }
    }
}
