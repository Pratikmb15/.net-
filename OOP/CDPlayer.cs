using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class CDPlayer : MediaPlayer
    {
        public void Start()
        {
            Console.WriteLine("Starting MediaPlayer!");
        }

        public void Stop()
        {
            Console.WriteLine("Stoping MediaPlayer!");
        }
    }
}
