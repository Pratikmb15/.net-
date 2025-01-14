using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myfirstproject
{
    internal class FrequencyofElements
    {
        public Dictionary<Char,int> CalculateFrequencyofEle(String str) {

            Dictionary<Char,int> keyValuePairs = new Dictionary<Char,int>();

            foreach (char c in str) {
                if (keyValuePairs.ContainsKey(c))
                {
                    keyValuePairs[c] += 1;
                }
                else {
                    keyValuePairs[c] = 1;

                }
            }
            return keyValuePairs;
        
        }    
    }
}
