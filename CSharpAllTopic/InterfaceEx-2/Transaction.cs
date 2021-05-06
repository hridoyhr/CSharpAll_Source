using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceEx_2
{
    public class Transaction
    {
        public string Name;
        public string tCode;
        public string tDate;
        public double Ammount;
        public double LoanAmmount;

        public Transaction()
        {
            Name = " ";
            tCode = " ";
            tDate = " ";
            Ammount = 0.00;
            LoanAmmount = 0.00;
        }
        public Transaction(string n,string c, string d, double a,double la)
        {
            Name = n;
            tCode = c;
            tDate = d;
            Ammount = a;
            LoanAmmount = la;
        }
        public double getTransaction()
        {
            return Ammount;
        }
        public double getLoan()
        {
            return LoanAmmount;
        }
        public double getVat()
        {
            return Ammount * 10 / 100; 
        }


        public void ShowTransaction()
        {
            Console.WriteLine("Transaction Name = {0}", Name);
            Console.WriteLine("Transaction Code = {0}", tCode);
            Console.WriteLine("Transaction Date = {0}", tDate);
            Console.WriteLine("Transaction Ammount = {0}", getTransaction());
            Console.WriteLine("Transaction Loan Ammount = {0}", getLoan());
            Console.WriteLine("Transaction Vat Ammount = {0}", getVat());
        }
    }
}
