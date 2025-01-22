using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review1
{
    internal class Car
    {
        private String Model ;
        private int Year;
        private int Speed;

      
        public Car(String NewModel, int NewYear, int NewSpeed)
        {
            this.Model = NewModel;
            this.Year = NewYear;
            this.Speed = NewSpeed;

        }
        public void Accelerate(int ToSpeed)
        {
            this.Speed = ToSpeed;
        }
        public void Deccelerate(int ToSpeed)
        { 
        this.Speed = ToSpeed;
        }
        public void DisplayCurrentSpeed() 
        { 
        Console.WriteLine(this.Speed.ToString());
        }
        public void Display() {
            Console.WriteLine(this.Model.ToString());
            Console.WriteLine(this.Year.ToString());
            Console.WriteLine(this.Speed.ToString());
        }

        public void SetModel(String NewModel) 
        { 
        this.Model=NewModel;
        }
        public String GetModel()
        {
            return Model;
        }

        public static void Main(String[] args) {
        Car NewCar = new Car("Fortuner",2024,80);
            NewCar.Accelerate(60);
            NewCar.DisplayCurrentSpeed();
            NewCar.Deccelerate(30);
            NewCar.DisplayCurrentSpeed();
            NewCar.Display();
            NewCar.SetModel("Thar");
            String CurrentModel= NewCar.GetModel();
            Console.WriteLine(CurrentModel);    
        }
    }
}
