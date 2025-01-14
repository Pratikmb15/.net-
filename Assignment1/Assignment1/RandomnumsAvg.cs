using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class RandomnumsAvg
    {
        public void AvgofRandomNums()
        {
            Random random = new Random();

            int[] arr = new int[5];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(10,51);
                Console.Write(arr[i]+" ");  
            }
            double avg = double.MinValue;
            int sum= 0;

            for(int j=0;j<arr.Length;j++)
            {
                sum += arr[j] ;
            }
            avg= sum / arr.Length;  
          
           Console.WriteLine("Average of five random numbers from range 10 to 50 "+avg); 



        }
    }
}
