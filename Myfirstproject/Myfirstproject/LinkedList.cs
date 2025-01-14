using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myfirstproject
{
    internal class LinkedList
    {
        private Node head;

        public void Insert(int data)
        {
            Node newnode = new Node(data);

            if (head == null)
            {
                head = newnode;
                return;

            }
            Node temp = head;

            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = newnode;

        }

        public void Delete(int data)
        {

            Node temp = head;
            while ((temp.Next != null) && (temp.Next.Data != data))
            {
                temp = temp.Next;

            }
            temp.Next = temp.Next.Next;
            Console.WriteLine($"{data} is Deleted");
        }
        public bool Search(int data) { 
        Node temp= head;
            while (temp!= null) {
                if (temp.Data == data)
                {
                    return true;
                }
                else
                { 
                    temp = temp.Next;
                }
            
            }
            return false;

        }

        public void display()
        {
            Node temp = head;
            if (head == null)
            {
                Console.WriteLine("Linkedlist is Empty!");
            }
            else 
            {
                Console.Write("Linked list :");
                while (temp!=null) {
                Console.Write(temp.Data+" ");
                    temp = temp.Next;
                }
            }
        }


    }
    class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }

        public Node(int data)
        {
            this.Data = data;
            this.Next = null;
        }
    }
}
