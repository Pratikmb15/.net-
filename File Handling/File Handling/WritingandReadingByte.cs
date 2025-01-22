using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Handling
{
    internal class WritingandReadingByte
    {
        public static void Main() {

            String filePath2 = @"c:\Users\PratikBagul\C#Data\test2.txt";

            FileStream fs = File.Open(filePath2,FileMode.Create);

            String randString = "This is Random String";

            byte[] rsByteArray = Encoding.Default.GetBytes(randString);

            fs.Write(rsByteArray,0,rsByteArray.Length);

            fs.Position = 0;

            byte[] fileByteArray = new byte[rsByteArray.Length];

            for (int i = 0; i < rsByteArray.Length; i++)
            {
                fileByteArray[i]= (byte)fs.ReadByte();
            }

            String ReadedString = Encoding.Default.GetString(fileByteArray);
            Console.WriteLine(ReadedString);
            fs.Close();

        }
    }
}
