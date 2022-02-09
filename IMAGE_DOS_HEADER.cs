using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe_A
{
    internal class IMAGE_DOS_HEADER : Heder
    {
        private convert con;
        private int sizeByte = 64;
        public string name = "IMAGE DOS HEADER";
        private int[] sizeWord = {
          2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,4 // elementa lielums
  	};
        private int[] countWord = { // cik elementu ir
  		1,1,1,1,1,1,1,1,1,1,1,1,1,1,4,1,1,10,1
      };
        public IMAGE_DOS_HEADER(bool ad, bool st, bool se, byte[] data) // Konstruktors
        {
            adress = ad;
            con = new convert();
            style = st;
            sectionLine = se;
            this.data = data;

            
            if (adress & style)
            {
                adresPrint = new string[19];
               // sum = new string[19];
            }
            else if ((adress & (!style)))
            {
                int row = 19 / colon;
                int rowA = 19 % colon;
                if(rowA > 1) { row++; }
                adresPrint = new string[row];
                if (sectionLine) // Ja sectionline = true tad pie summ pivieno atdalošas linijas
                {
                    sum = new string[22];
                    sum[0] = "	" + name;
                    sum[1] = "___________________________________";
                    sum[21] = sum[1];
                }
                else
                {
                    sum = new string[row];
                }
            }
            
           
        }
        public string[] ValueName = {
       "u16 e_magic",	// 0x5A4D	"MZ"
        "e_cblp",		// 0x0080	128
        "e_cp",		    // 0x0001	1
        "e_crlc",
        "e_cparhdr",	// 0x0004	4
        "e_minalloc",	// 0x0010	16
        "e_maxalloc",	// 0xFFFF	65535
        "e_ss",
        "e_sp",		    // 0x0140	320
        "e_csum",
        "e_ip",
        "e_cs",
        "e_lfarlc",	    // 0x0040	64
        "e_ovno",
        "e_res",
        "e_oemid",
        "e_oeminfo",
        "e_res2",
        "e_lfanew",	    // 0x0080	128
  	};
        private void formAdres() // aizpilda masivu kas domats adresem
        {
            if (style)
            {
                byte counter = 0;
                for(int i = 0; i < adresPrint.Length; i++)
                {
                    adresPrint[i] = "0x" + con.ToHex1(counter);
                    int a = sizeWord[i] * countWord[i];
                    byte b = Convert.ToByte(a);
                   // counter = counter + b;
                   // counter = counter + (Convert.ToSByte(sizeWord[i]) * Convert.ToSByte(countWord[i]));
                }
            }
        }

        public string[] Analize()
        {





            return sum;
        }
    }
}
