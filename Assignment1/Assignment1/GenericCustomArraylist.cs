using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class GenericCustomArraylist<T>
    {
        private Object[] data;
        private static int Defaultsize = 10;
        private int size = 0;

        public GenericCustomArraylist()
        {
            this.data = new Object[Defaultsize];
        }

        public void add(T num)
        {
            if (isFull())
            {
                resize();
            }
            data[size++] = num;
        }

        public void  Delete()
        {
            if (size == 0)
            {
                Console.WriteLine("List is Empty!");
                

            }
            else
            {
                size = size - 1;


            }
        }
        public void set(int index, T val)
        {
            data[index] = val;
        }

        public bool isFull()
        {
            return size == data.Length;
        }
        public void resize()
        {
            Object[] temp = new Object[data.Length * 2];
            for (int i = 0; i < data.Length; i++)
            {
                temp[i] = data[i];
            }
            data = temp;
        }
        public void Display()
        {
            Console.Write("[");
            for (int i = 0; i < size; i++)
            {
                Console.Write(data[i] + " ");
            }
            Console.Write("]");
            Console.WriteLine();
        }

       
    }
}
