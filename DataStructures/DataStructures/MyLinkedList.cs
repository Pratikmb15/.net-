using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    internal class MyLinkedList
    {
        private Node head;


        public void AddAfterval(int val,int data) 
        {
            Node Prev = getNode(val);
            if (Prev == null)
            {
                Console.WriteLine($"No Node Found with value : {val}");
            }
            if (Prev == head)
            {
                AddasHead(val);
            }
            else
            {
                Node newnode = new Node(data);
                Node temp2 = Prev.Next;
                Prev.Next = newnode;
                newnode.Next = temp2;
            }

        }
        public void AddafterNode(Node Prev,int data)
        {
            if (Prev == null)
            {
                Console.WriteLine("Enter Valid Node !");
            }
            else
            {
                Node newnode = new Node(data);
                Node temp3 = Prev.Next;
                Prev.Next = newnode;
                newnode.Next = temp3;
            }
        }
        public Node getNode(int val) 
        {
            Node temp=head;
            while (temp!=null) 
            {
                if (temp.Data == val)
                {
                return temp;
                }
            temp = temp.Next;   
            }
            return null;
        }
        public void AddasHead(int data)
        {
            Node newnode = new Node(data);
            if (head == null)
            {
                newnode = head;
            }
            else 
            {
             newnode.Next = head;
             head = newnode;
            }
        }
        public void AddasTail(int data)
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
            if (temp.Data == data) {
                Node T = head.Next;
                head=T;
                Console.WriteLine($"{data} is Deleted");
                return;
            }
            while ((temp.Next != null) && (temp.Next.Data != data))
            {
                temp = temp.Next;

            }
            temp.Next = temp.Next.Next;
            Console.WriteLine($"{data} is Deleted");
        }
        public bool Search(int data)
        {
            Node temp = head;
            while (temp != null)
            {
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
                while (temp != null)
                {
                    Console.Write(temp.Data + "->");
                    temp = temp.Next;
                }
                Console.WriteLine("Null");
            }
        }
        public static void Main(String[] args) { 
        MyLinkedList Llist = new MyLinkedList();
            Llist.AddasTail(5);
            Llist.AddasTail(52);
            Llist.AddasTail(84);
            Llist.AddasTail(79);

            Llist.display();

            Node Target = Llist.getNode(84);
            Llist.AddafterNode(Target,10);

            Llist.display();

            Llist.Delete(5);

            Llist.display();
        }

    }
  
}
