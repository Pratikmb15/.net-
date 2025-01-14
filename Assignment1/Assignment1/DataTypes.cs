using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class DataTypes
    {
        
       public void datatype()
            {

                int num = 10;
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine(num + " " + n);

                long number = 8411165407;
                long ln = long.Parse(Console.ReadLine());

                Console.WriteLine(number + " " + ln);

                char ch = 'A';
                char c = char.Parse(Console.ReadLine());
                Console.WriteLine(ch + " " + c);

                String str = "ABC";
                String s = Console.ReadLine();
                Console.WriteLine(str + " " + s);

                float flt = 8.75F;
                float fl = float.Parse(Console.ReadLine());
                Console.WriteLine(flt + " " + fl);

                double dnum = 7.511777777777D;
                double db = double.Parse(Console.ReadLine());

                Console.WriteLine(dnum + " " + db);
       }
    }
}


