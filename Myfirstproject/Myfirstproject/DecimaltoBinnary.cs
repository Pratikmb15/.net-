using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myfirstproject
{
    internal class DecimaltoBinnary
    {
        public String ConvertDectoBin(int Decimalnum)
        {
            String Binnarynum = "";
            if (Decimalnum < 0) { throw new ArgumentException("Invalid Number!"); }
            while (Decimalnum > 0)
            {
                int Remainder = Decimalnum % 2;
                Binnarynum += Remainder.ToString();
                Decimalnum = Decimalnum / 2;
            }
            return Binnarynum;
        }

    }
}
