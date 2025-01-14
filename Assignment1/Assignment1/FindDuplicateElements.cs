using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class FindDuplicateElements
    {
        public void FindDuplicates(ArrayList arrayList) {
          HashSet<object> Seen = new HashSet<object>();
          HashSet<object> Duplicates = new HashSet<object>();

            foreach (var element in arrayList) {
                if (!Seen.Add(element)) {
                    Duplicates.Add(element);
                }
            }
            if (Duplicates.Count == 0) {
                Console.WriteLine("There are no Duplicate elements");
            }else{
                Console.WriteLine("Duplicates are:");
                foreach (var element in Duplicates)
                {
                    Console.Write(element+" ");
                }
                Console.WriteLine();
            }
        
        }
        public static void Main(string[] args) { 
        ArrayList arrayList = new ArrayList();
            arrayList.Add(false); 
            arrayList.Add("Anna");
            arrayList.Add(20);
            arrayList.Add(new DateTime(2021, 4, 15, 12, 10, 51));
            arrayList.Add(new DateTime(2024, 5, 15, 12, 56, 45));
            arrayList.Add(12.56);
            arrayList.Add("Anna");
          FindDuplicateElements finder = new FindDuplicateElements();
            finder.FindDuplicates(arrayList);




        }
    }
}
