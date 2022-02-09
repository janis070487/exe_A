using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace exe_A
{
    internal class LoadFile
    {
        private string path;
        public int erorrCode = 0;

        byte[] data;
        public LoadFile(string path)
        {
            this.path = path;
        }
        public byte[] Load()
        {
            if (File.Exists(path))
            {
                data = File.ReadAllBytes(path);
                return data;
                erorrCode = 1;
               // this.erorrCode = "Fails tika nolasīts";
            }
            else
            {
                erorrCode = 0;
                return null;
            }
            //string[] result = new string[0];

        }
    }
}
