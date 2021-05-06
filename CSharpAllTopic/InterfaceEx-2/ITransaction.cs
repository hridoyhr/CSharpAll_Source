using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceEx_2
{
    public interface ITransaction
    {
        void showTransaction();
        void getLoan();
        void getAmount();
        void getVat();
    }
}
