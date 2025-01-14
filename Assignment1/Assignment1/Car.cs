using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Car
    {
        private String  Brand = "Tata";
        private int Sales =1500;

        public int Carsales()
        {
            return Sales;
        }
        
        public String getBrand()
        { 
            return this.Brand;
        }
        public void setBrand(String Brandname) 
        {
            this.Brand = Brandname;
        }
    }
    
}
