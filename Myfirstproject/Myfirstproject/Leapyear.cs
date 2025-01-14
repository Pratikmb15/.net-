using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myfirstproject
{
    internal class Leapyear
    {
        public bool CheckifLeap(int year)
        {
            if(year%4==0){ return true; }

            else return false;
        }
    }
}
