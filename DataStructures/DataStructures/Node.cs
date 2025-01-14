using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class Node
    {
        public int Data;
        public Node Next;
        
        public Node(int d)
        {
            this.Data = d;
            this.Next = null;
        }
    }
}
