using System;

namespace InterfaceEx_1
{
    class Program
    {
        static void Main(string[] args)
        {
            IFile file1 =new FileInfo();
            IBinaryFile file2 =new FileInfo();
            FileInfo file3 =new FileInfo();

            file1.ReadFile();
        }
    }
}
