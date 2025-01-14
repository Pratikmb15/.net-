using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Executiontime
    {
        public void FindExecutionTime() { 
        Stopwatch stopwatch = Stopwatch.StartNew(); 
        stopwatch.Start();
            Performtask();
        stopwatch.Stop();

            Console.WriteLine($"Execution time of program is {stopwatch.ElapsedMilliseconds} ms");
        }
        public void Performtask() {

            for (int j = 0; j < 1000000; j++) {
                int x = j * j;
                double y = Math.Sqrt( x );

            }
            return;
        }
    }
}
