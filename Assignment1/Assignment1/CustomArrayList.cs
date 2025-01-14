using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class CustomArrayList
    {
        private int[] data;
        private static int Defaultsize = 10;
        private int size = 0;

        public CustomArrayList() { 
        this.data = new int[Defaultsize];   
        }

        public void add(int num) {
            if (isFull()) {
                resize();
            }
            data[size++] = num;
        }

        public int delete() {
            if (size == 0)
            {
                Console.WriteLine("List is Empty!");
                return 0; 
            }
            else
            {
               return  data[--size];
            }
        }
        public void set(int index, int val)
        {
            data[index]= val;   
        }

        public bool isFull() { 
        return size==data.Length;
        }
        public void resize() { 
        int[] temp=new int[data.Length*2];
            for (int i = 0; i < data.Length; i++)
            {
                temp[i]=data[i];
            }
            data = temp;
        }
        public void Display() {
            Console.Write("[");
            for (int i = 0; i < size; i++) {
                Console.Write(data[i]+" ");
            }
            Console.Write("]");
            Console.WriteLine();
        }

        public static void Main(String[] args) { 
        CustomArrayList customArrayList = new CustomArrayList();
            customArrayList.add(5);
            customArrayList.add(18);
            customArrayList.add(23);
            customArrayList.add(11);
            customArrayList.add(24);
            

            customArrayList.Display();
            customArrayList.delete();
            customArrayList.Display();

            customArrayList.set(2,35);
            customArrayList.Display();

            customArrayList.add(7);
            customArrayList.add(63);
            customArrayList.add(41);
            customArrayList.add(76);
            customArrayList.add(83);
            customArrayList.add(27);
            customArrayList.add(4);
            customArrayList.add(99);
            customArrayList.add(57);
            customArrayList.add(45);
            customArrayList.add(23);
            customArrayList.add(32);
            customArrayList.Display();



        }

    }
}
