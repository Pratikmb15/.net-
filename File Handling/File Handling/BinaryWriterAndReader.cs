using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Handling
{
    internal class BinaryWriterAndReader
    {
        public static void Main(String[] args) {

            String filePath4 = @"c:\Users\PratikBagul\C#Data\test4.dat";

            FileInfo datfile = new FileInfo(filePath4);

            BinaryWriter bw =  new BinaryWriter(datfile.OpenWrite());

            String randStr = "This is Random String";
            int num = 56;
            double dnum = 78.56;
            
            bw.Write(randStr);
            bw.Write(num);
            bw.Write(dnum);

            bw.Close();

            BinaryReader br = new BinaryReader(datfile.OpenRead());
            Console.WriteLine(br.ReadString());
            Console.WriteLine(br.ReadInt32());
            Console.WriteLine(br.ReadDouble());

            br.Close();
        }
    }
}
