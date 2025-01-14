using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    internal class MyQueue
    {
        private Node front;
        private Node rear;

        public MyQueue() { 
        this.front = null;
        this.rear = null;
        }
        public void Enqueue(int data) {
            Node newnode = new Node(data);
            if (isEmpty())
            {
                
                front = rear = newnode;
            }
            else { 
            rear.Next = newnode;
            rear=newnode;
            }
        }
        public int Dequeue() {
            if (isEmpty()) {
                Console.WriteLine("Queue is Empty");
                return -1;
            }
            int Dequeued = front.Data;
            front = front.Next;
            Console.WriteLine($"{Dequeued} is Dequeued Succesfully !");
            return Dequeued;
        }

        private bool isEmpty()
        {
            return front == null;
        }

        public void 

        public static void Main(String[] args) {
            MyQueue NQueue = new MyQueue();
            NQueue.Enqueue(1);
            NQueue.Enqueue(12);
            NQueue.Enqueue(13);
            NQueue.Enqueue(14);
            NQueue.Enqueue(14);

            NQueue.Dequeue();



        }
    }
}
