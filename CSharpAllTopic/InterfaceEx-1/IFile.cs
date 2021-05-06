using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceEx_1
{
    public interface IFile
    {
        void ReadFile();
    }
    public interface IBinaryFile
    {
        void OpenBinaryFile();
        void ReadFile();
    }
}
