using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Parking
    {
        int ParkingCapacity;
        int ParkingOccupied = 0;
        String ParkingStatus = "Vacant";
        String[] ParkingSlots;
        public Parking(int Capacity)
        {
            this.ParkingCapacity = Capacity;
            this.ParkingSlots = new String[Capacity];   
        }

        public void ParkNewcar(String Name)
        {
            if (IsFull())
            {
                ParkingStatus = "Full";
                Console.WriteLine("Parking is Full !");
            }
            else
            {
               int Vacant =getVacant();
                ParkingSlots[Vacant]= Name;
                ParkingOccupied++;
                Console.WriteLine($"Parking no.{Vacant+1} is alloted to {Name} Succesfully !");
            }
        }
        public void RemoveCar(int ParkingNum)
        {
            if (ParkingOccupied == 0 || ParkingSlots[ParkingNum - 1] == null)
            {
                Console.WriteLine("Parking Slot is Empty!");
            }
            else
            {
                String Name = ParkingSlots[ParkingNum - 1];
                ParkingSlots[ParkingNum - 1] = null;
                ParkingOccupied--;
                Console.WriteLine($" {Name} Removed from Parking Slot {ParkingNum} Succesfully");
            }
        }
        public bool IsFull()
        {
            return ParkingOccupied == ParkingCapacity;
        }
        public void Display()
        {
            Console.WriteLine($"Current Parking Status: {ParkingStatus}");
            Console.WriteLine("Parking Slots:");
            for (int i = 0; i < ParkingCapacity; i++)
            {
                if (ParkingSlots[i] != null)
                {
                    Console.WriteLine($"Slot {i + 1}: {ParkingSlots[i]}");
                }
                else
                {
                    Console.WriteLine($"Slot {i + 1}: Vacant");
                }
            }
        }
        public int getVacant() {
            for (int i = 0; i < ParkingCapacity; i++) {
                if (ParkingSlots[i] == null)
                {
                    return i;
                } 
            }
            return 0;
        }
        public static void Main(string[] args)
        {
            Parking NewParking = new Parking(15);
            Console.WriteLine("Enter Your Role:\n 1.Owner \n 2.Security");
            String role = Console.ReadLine();
            switch (role)
            {
                case "Owner":
                    Console.WriteLine("Enter Any of Below options:\n 1. Park Car \n 2. Unpark Car");
                    int op = int.Parse(Console.ReadLine());
                    switch (op) {
                        case 1:
                            Console.WriteLine("Enter Car Name");
                            String Name = Console.ReadLine();
                            NewParking.ParkNewcar(Name);
                            break;
                        case 2:
                            Console.WriteLine("Enter Parking Slot number Name");
                            int Slotnum = int.Parse(Console.ReadLine());
                            NewParking.RemoveCar(Slotnum);
                            break;
                        default:
                            Console.WriteLine("Enter Valid Option");
                            break;
                    }
                    break;
                case "Security":
                    Console.WriteLine("Enter:\n1. Get Parking Status");
                    int opt = int.Parse(Console.ReadLine());
                    
                        switch (opt)
                        {
                            case 1:
                                NewParking.Display();
                                break;
                            default:
                                Console.WriteLine("Enter a valid option!");
                                break;
                        }
                         break;
                default:
                    Console.WriteLine("Enter a valid role (owner/security).");
                break;
            }
        }

    }
}


