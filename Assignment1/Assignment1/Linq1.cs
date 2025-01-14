using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Linq1
    {
        public static void Main(String[] args) {
            List<int> Scores = new List<int> { 75, 80, 65, 90, 85 };

            var highScoresQuery = (from score in Scores where score > 70 select score).OrderByDescending(n=>n).ToList();

            foreach (var score in highScoresQuery) { 
            Console.WriteLine(score);
            
            }    
        }
    }
}
