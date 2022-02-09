using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe_A
{
    internal class convert
    {
        public
  //__________
  string ToBinaryInt32(int x)
        {
            string sum = "";
            char[] buff = new char[32];

            for (int i = 31; i >= 0; i--)
            {
                int mask = 1 << i;
                buff[31 - i] = (x & mask) != 0 ? '1' : '0';
            }

            for (int i = 0; i < buff.Length; i++)
            {
                sum = sum + buff[i];
            }
            return sum;

        }
        //___________
        public string ToBinaryChar(char a)
        {
            Int16 b = Convert.ToInt16(a);
            string sum = null;
            char[] buff = new char[16];
            for (int i = 15; i >= 0; i--)
            {
                int mask = 1 << i;
                buff[15 - i] = (a & mask) != 0 ? '1' : '0';
            }
            for (int i = 0; i < buff.Length; i++)
            {
                sum = sum + buff[i];
            }

            //Console.WriteLine(b);



            return sum;
        }
        //_________
        public string ToHex1(byte a)
        {
            string sum = null;
            int aa = Convert.ToInt32(a);

            //	byte shift = 4;
            int counter = 0;
            int mask = 240;
            for (int i = 0; i < 2; i++)
            {
                if (counter == 0)
                {
                    aa = aa & mask;
                    aa = aa >> 4;
                    mask = 15;
                }
                else
                {
                    aa = aa & mask;
                }
                switch (aa)
                {
                    case 0:
                        sum = sum + '0';
                        break;
                    case 1:
                        sum = sum + '1';
                        break;
                    case 2:
                        sum = sum + '2';
                        break;
                    case 3:
                        sum = sum + '3';
                        break;
                    case 4:
                        sum = sum + '4';
                        break;
                    case 5:
                        sum = sum + '5';
                        break;
                    case 6:
                        sum = sum + '6';
                        break;
                    case 7:
                        sum = sum + '7';
                        break;
                    case 8:
                        sum = sum + '8';
                        break;
                    case 9:
                        sum = sum + '9';
                        break;
                    case 10:
                        sum = sum + 'A';
                        break;
                    case 11:
                        sum = sum + 'B';
                        break;
                    case 12:
                        sum = sum + 'C';
                        break;
                    case 13:
                        sum = sum + 'D';
                        break;
                    case 14:
                        sum = sum + 'E';
                        break;
                    case 15:
                        sum = sum + 'F';
                        break;

                }
                counter = 1;
                //mask = a;
                aa = Convert.ToInt32(a);
            }
            return sum;
        }
        //_____________________________
        public string ToHex4(uint a)
        {
            string sum = null;
            uint aa = a;

            //	byte shift = 4;
            //int counter = 0;
            uint mask = 4026531840;
            for (int i = 0; i < 8; i++)
            {
                    aa = aa & mask;
                    aa = aa >> 4;
                    aa = aa & mask;
                    mask = mask >> 4;

                switch (aa)
                {
                    case 0:
                        sum = sum + '0';
                        break;
                    case 1:
                        sum = sum + '1';
                        break;
                    case 2:
                        sum = sum + '2';
                        break;
                    case 3:
                        sum = sum + '3';
                        break;
                    case 4:
                        sum = sum + '4';
                        break;
                    case 5:
                        sum = sum + '5';
                        break;
                    case 6:
                        sum = sum + '6';
                        break;
                    case 7:
                        sum = sum + '7';
                        break;
                    case 8:
                        sum = sum + '8';
                        break;
                    case 9:
                        sum = sum + '9';
                        break;
                    case 10:
                        sum = sum + 'A';
                        break;
                    case 11:
                        sum = sum + 'B';
                        break;
                    case 12:
                        sum = sum + 'C';
                        break;
                    case 13:
                        sum = sum + 'D';
                        break;
                    case 14:
                        sum = sum + 'E';
                        break;
                    case 15:
                        sum = sum + 'F';
                        break;

                }
               
                //mask = a;
                aa = a;
            }
            return sum;
        }

    }
}
