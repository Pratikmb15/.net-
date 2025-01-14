using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    internal class DNode
    {

      public int Data;
      public Node Next;
      public Node PrevNode;
      public DNode(int data)
            {
                this.Data = data;
                this.Next = null;
                this.PrevNode = null;
      }
    }
}
