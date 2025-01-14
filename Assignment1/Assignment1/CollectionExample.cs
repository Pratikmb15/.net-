using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class CollectionExample
    {
        public static void Main(string[] args) {

            //------------------------------Non Generic Collections------------------------------------------------------
            //ArrayList Alist = new ArrayList();
            //Alist.Add(5);
            //Alist.Add(8);
            //Alist.Add(13);
            //Alist.Add(4);

            //Alist.Remove(8);

            //foreach(var i in Alist) {
            // Console.Write(i+" ");
            //}

            //Hashtable hash = new Hashtable();
            //hash.Add("Football", 700);
            //hash.Add("BasketBall", 1200);
            //hash.Add("Tenis Ball", 60);

            //foreach (DictionaryEntry entry in hash)
            //{
            //    Console.WriteLine(entry.Key + " " + entry.Value);
            //}
            //hash.Remove("BasketBall");
            //if (hash.ContainsKey("Football"))
            //{
            //    Console.WriteLine("Hash table Contains Football");
            //}


            //Stack Nstack = new Stack();
            //Nstack.Push(10);
            //Nstack.Push("Pratik");
            //Nstack.Push('+');

            //Nstack.Push('-');

            //foreach (var elements in Nstack) {
            //    Console.WriteLine(elements);
            //}

            //Nstack.Pop();

            //Queue ngq = new Queue();
            //ngq.Enqueue(1);
            //ngq.Enqueue(12.508);
            //ngq.Enqueue('+');
            //ngq.Enqueue("Non-Generic");

            //ngq.Dequeue();

            //foreach (var ngitems in ngq) {
            //Console.WriteLine(ngitems);
            //}
            

            //-----------------------------------------Generic Collections-----------------------------------------------------------------
            //SortedList<int, String> sortedList = new SortedList<int, String>();
            //sortedList.Add(15, "Pratik");
            //sortedList.Add(25, "Kunal");
            //sortedList.Add(7, "Rohit");
            //sortedList.Add(13, "Vinod");


            //sortedList.Remove(25);
            //foreach (KeyValuePair<int, String> ch in sortedList)
            //{
            //    Console.WriteLine(ch.Key + " " + ch.Value);
            //}


            //Stack<int> stack = new Stack<int> (); 
            //stack.Push (45);  
            //stack.Push (22);
            //stack.Push (28);
            //stack.Push (47);
            //stack.Push (33);
            //stack.Push (2);

            //if (stack.Contains(47))
            //{
            //    Console.WriteLine("Element Found!");
            //}
            //else { return; }

            //foreach (int num in stack)
            //{
            //    Console.WriteLine(num);
            //}

            //Queue<String> queue = new Queue<String>();
            //queue.Enqueue("High");
            //queue.Enqueue("Mid");
            //queue.Enqueue("Low");

            //queue.Dequeue();

            //foreach (var item in queue) { 
            //Console.WriteLine(item);
            //}



            //LinkedList<string> list = new LinkedList<string>();
            //list.AddLast("Node1");
            //list.AddLast("Node2");
            //list.AddLast("Node3");
            //list.AddLast("Node4");
            //list.AddLast("Node5");

            //list.AddFirst("NewNode");

            //LinkedListNode<string> node = list.Find("Node3");   
            //list.AddAfter(node,"AddedNode");

            //foreach (var item in list) { 
            //Console.WriteLine(item);    
            //}

            //Dictionary<int, String> dict = new Dictionary<int, string>();
            //dict.Add(10, "Rohit");
            //dict.Add(12, "Aryan");
            //dict.Add(13, "Sanya");
            //dict.Add(14, "Anushka");

            //foreach (KeyValuePair<int, String> keyValuepair in dict)
            //{
            //    Console.WriteLine(keyValuepair.Key + " " + keyValuepair.Value);
            //}
            //dict.Remove(13);
            //foreach (KeyValuePair<int, String> keyValuepair in dict)
            //{
            //    Console.WriteLine(keyValuepair.Key + " " + keyValuepair.Value);
            //}
            //Console.WriteLine(dict.ContainsKey(13));
            // var v=dict.TryGetValue(14, out var value);
            //Console.WriteLine(v);

            //List<char> list = new List<char>();
            //list.Add('a');
            //list.Add('b');
            //list.Add('c');
            //list.Add('d');
            //list.Add('e');
            //list.Add('f');


            //list.Remove('d');
            //foreach (var ele in list)
            //{
            //    Console.WriteLine(ele);
            //}








        }
    }
}
