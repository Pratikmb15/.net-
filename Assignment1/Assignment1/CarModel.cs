using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class CarModel : Car
    {
        public String model;
        public String brand;
        

        public void Carmodel(String model, String newbrand)
        {
            setBrand(newbrand);
            this.brand=getBrand();
            this.model = model;
          
        }
        
      
    }
}
