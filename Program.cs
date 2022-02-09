using System;

namespace exe_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte[] data = null;
            convert con = new convert();
            LoadFile fails = new LoadFile("ConsoleApplication1.exe");
            data = fails.Load();
            IMAGE_DOS_HEADER IDH = new IMAGE_DOS_HEADER(true, true, true, data);
            




           /* byte[] data = null;
            convert con = new convert();
            LoadFile fails = new LoadFile("ConsoleApplication1.exe");
            data = fails.Load();
            string print = null;
            string asic = null;
            int adrese = 0;
            Console.WriteLine(data.Length);
            for (int i = 0; i < data.Length / 16; i++)
            {
                
                for(int a = 0; a < 4; a ++){
                    print = print + "0x";
                    for (int b = 0; b < 4; b++)
                    {
                        
                         print = print + con.ToHex1(data[adrese]);
                        adrese++;
                        //asic = asic + Convert.ToChar(data[i * a * b]);

                        // print = print + 
                        //Console.WriteLine("0x" + con.ToHex1(data[i]) + ' ');
                    }
                    print = print + "\t";
                }
                Console.WriteLine(print);
                print = null;
                //asic = null;
            }
           */
        }
    }
}
