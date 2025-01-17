using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Engines : Engine
    {
        public void Start()
        {
            Console.WriteLine("Starting Engine Ignition !");
        }
        public void Stop()
        {
          Console.WriteLine("Stoping Engine ! ");
        }
    }
}
