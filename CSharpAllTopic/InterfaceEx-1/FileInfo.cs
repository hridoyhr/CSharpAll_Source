using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceEx_1
{
    public class FileInfo : IFile, IBinaryFile
    {
        void IFile.ReadFile()
        {
            Console.WriteLine("Reading Text File");
        }
        void IBinaryFile.OpenBinaryFile()
        {
            Console.WriteLine("Open Binary File");
        }
        void IBinaryFile.ReadFile()
        {
            Console.WriteLine("Read Binary File");
        }

        public void Serach(string text)
        {
            Console.WriteLine("Serachin in File");
        }
    }
}
