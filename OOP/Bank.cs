using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    abstract public class Bank
    {   
        
        abstract public void credit(int password,float money);
       
        abstract public void Debit(int password, float money);

        abstract public bool login(int password);

        

    }
}
