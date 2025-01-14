using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    internal class MyStack
    {
        private Node Top;

        public MyStack() 
        {
        this.Top = null;
        }

        public void Push(int val) 
        {
        Node newnode = new Node(val);
            newnode.Next = Top;
            Top = newnode;
        }
        public int pop() {
            if (isEmpty())
            {
                Console.WriteLine("Stack is Empty !");
                return -1;
            }
            else {
                int poped = Top.Data;
                Top=Top.Next;
                Console.WriteLine($"{poped} is Popped Succesfully");
                return poped;
            }
        }
        public int peek()
        {
            if (isEmpty())
            {
                Console.WriteLine("Stack is Empty !");
                return -1;
               
            }
            else {
                int PeekElement = Top.Data;
                Console.WriteLine($"Peek Element is {PeekElement}");
                return PeekElement;
            }
        }
        public bool isEmpty() { 
        return Top==null;
        }

        public void Display() {
            if (isEmpty())
            { 
            Console.WriteLine("Stack is Empty !");
                return;
            }
        Node Current = Top;
            while (Current != null) { 
           Console.Write(Current.Data+" ");
                Current = Current.Next; 
            }
            Console.WriteLine();
        }

        public static void Main(string[] args) { 

            MyStack nStack = new MyStack(); 
            nStack.Push(11);
            nStack.Push(23);
            nStack.Push(87);
            nStack.Push(78);
            nStack.Push(64);
            nStack.Push(36);

            nStack.Display();

            nStack.peek();
            nStack.pop();

            nStack.Display();


        }
    }
}
