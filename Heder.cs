using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe_A
{
    internal class Heder
    {
       
        static byte adresPoint = 0;        // Kurš baits tagad janolasa no data
        public string[] adresPrint = null;  // Glaba adreses
        public byte[] data = null;          // saite uz exe faila datiem
        public int colon = 4;               // cik daudz kolonas
        public int colonSize = 0;           // cik viena varda ir baytu
        public bool adress = true;          // vai vajag izprintet adreses
        public bool style = true;           // vai vajag izprintet noformējuma
        public bool sectionLine = false;    // vai pievienot linijas robezas
        public string[] sum = null;
        
    }
}

