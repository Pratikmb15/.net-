using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myfirstproject
{
    internal class PerfectSquare
    {
        public bool CheckPerfectSquare(double num)
        {
            double sqrt = Math.Sqrt(num);
        
            return sqrt*sqrt==num;
            
        }
    }
}
