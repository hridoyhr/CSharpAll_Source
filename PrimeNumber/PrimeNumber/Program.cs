using System;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            //for (int i = 1; i < 600; i++)
            //{
            //    if ((i % 1 == 0 || i % i == 0) && (i % 2 == 0 || i % 3 == 0 || i % 4 == 0 || i % 5 == 0 || i % 6 == 0 || i % 7 == 0 || i % 8 == 0 || i % 9 == 0))
            //    {

            //    }
            //    else
            //    {
            //        Console.WriteLine("Prime = {0}", i);

            //    }

            //}


            Program obj = new Program();
            var p = obj.Sum(3, 4);
            var m = obj.Mul(7, 7);
            Console.WriteLine(p);
            Console.WriteLine(m);

            obj.Calculation();

            obj.Div(7.5 , 7.5, 5);

            var s = obj.Student("Hridoy ", "Hasan ", "hasib ");
            Console.WriteLine(s);
            var c = obj.Company("Hello");
            Console.WriteLine(c);

            var e = obj.Floating(3.5f , 3.5f);
            Console.WriteLine(e);

            var f = obj.DivFloat(7.5f, 7.5f, 5);
            Console.WriteLine(f);

            var g = obj.sumfloat(3.5f, 3.5f);
            Console.WriteLine(g);

            var h = obj.mulFloat(3.5f, 3.5f);
            Console.WriteLine(h);

            Console.WriteLine(obj.Equation());

            var i = obj.mulDouble(3.5, 3.5, 3.5);
            Console.WriteLine(i);

            var j = obj.stringDouble("Hridoy ", "hasan");
            Console.WriteLine(j);

            var k = obj.Char('H', 'h');
            Console.WriteLine(k);

            var l = obj.Length('A');
            Console.WriteLine(l) ;

            var n = obj.Valid(5, 22);
            Console.WriteLine(n);

            var o = obj.isP(7);
            Console.WriteLine(o);

            var q = obj.CompareLength("Hridoy", "HasanR");
            Console.WriteLine(q);

            var r = obj.DoubleLength(3.5, 3.5);
            Console.WriteLine(r);

            var t = obj.intLength(2, "Hasan");
            Console.WriteLine(t);

            obj.Name();

            var z = obj.StudentInfo("Rakib", "rakib@gmail.com", "Dhaka");
            Console.WriteLine(z);

            obj.FirstName = "Hasan";
            obj.Email = "hasan@gmail.com";
            obj.Address = "Dhaka bangladesh";

            obj.Information(4, 5, 6);
            obj.Display();

            obj.CompanyName = "Selis";
            obj.CEmail = "Selis@gmai.com";
            obj.CAddress = "Dhanmondi, Dhaka";

            obj.CDisplay();

            var x = obj.PrintallOdd(100);
            Console.WriteLine(x);

            var w = obj.PrintAllEven(50);
            Console.WriteLine(w);

            obj.Nothing();
        }
        //1
        public string Sum(int num1, int num2)
        {
            int sum = num1 + num2;
            Console.WriteLine(sum);
            return "Sum is ";
        }
        //2
        protected int Mul(int num1, int num2)
        {
            return num1 * num2;
        }
        //3
        internal int Calculation()
        {
            int i = 4;
            int j = 4;
            int k = 4;

            int cal = i + j - k;
            Console.WriteLine("Calculation {0}",cal);
            return 0;
        }
        //4
        public int Cal(int a, int b, int c)
        {
            return a + b + c;
        }
        //5
        public string Student(string a, string b, string c)
        {
            Console.WriteLine("Student List");
            var add = a + b + c;
            Console.WriteLine(add);

            return "Done";
        }
        //6
        private string Div(double a, double b, int c)
        {
            var div = (a + b) / c;
            Console.WriteLine("Divided private class {0}", div);
            return "Divided";
        }
        //7
        public string Company(string cName)
        {
            return "Braint Station";
        }
        //8
        public float Floating(float a, float b)
        {
            var f = a + b;
            Console.WriteLine(f);
            return 4.5f;
        }
        //9
        public float DivFloat(float a, float b, int c)
        {
            var div = (a + b) / c;
            Console.WriteLine(div);
            return 4.555f;
        }
        //10
        public string sumfloat(float a, float b)
        {
            var sum = a + b;
            Console.WriteLine(sum);
            return "Floating";
        }
        //11
        private float mulFloat(float a, float b)
        {
            return a * b;
        }
        //12 
        internal double sumDouble(double a , double b)
        {
            return a + b;
        }
        //13
        public double Cal(double a, double b, double c)
        {
            var cal = (a + b) / c;
            Console.WriteLine(cal);
            return 12.45;
        }
        //14
        protected double Equation()
        {
            return 4555.66;
        }
        //15 
        private double mulDouble(double a , double c, double d)
        {
            return 3.5 + a + c + d;
        }
        //16
        private double stringDouble(string a, string b)
        {
            string num = a + b;
            Console.WriteLine(num);
            return 3.5;
        }
        //17
        public char Char(char a, char b)
        {
            return 'A';
        }
        //18
        private char Length(char a)
        {
            return 'a';
        }
        //19
        public string Names(string a, string b)
        {
            var add = a + b;
            Console.WriteLine(add);
            return "This is Student";
        }
        //20
        public bool Valid(int a, int b)
        {
            if(a > b)
                Console.WriteLine("a is bigger than b");
            else
            {
                return false;
            }
            return true;
        }
        //21
        public bool isP(int n)
        {
            if (n % 2 == 0)
            {
                return true;
            }
            else
                return false;
        }
        //22
        public bool CompareLength(string a, string b)
        {
            if (a.Length == b.Length)
                return true;
            else
                return false;
        }
        //23
        public string DoubleLength(double a, double b)
        {
            
            if (a == b)
                return "a and b equal";
            else
                return "a and b not equal";
        }
        //24
        private string intLength(int a, string b)
        {
            if (a.GetType() == b.GetType())
                return "This two values data type are equal";
            else
                return "Data type are not equal";
        }
        //25
        
        public int SumInt(int a, int b, int c)
        {
            return a + b + c;
        }

        //26
        public bool isItValid(string a, string b)
        {
            var c = a + b;
            Console.WriteLine(c);
            return true;
        }
        //27
        protected void NoReturn(int a, int b)
        {
            int sum = a + b;
        }
        //28
        public void Name()
        {
            string firstName = "hasan";
            string lastName = "hasib";
            Console.WriteLine($"{firstName}, {lastName} ");
        }
        //29
        public string StudentInfo(string FullName, string Email, string Address)
        {
            Console.WriteLine(FullName);
            Console.WriteLine(Email);
            Console.WriteLine(Address);

            return "Submitted";
        }
        //30
        public string FirstName;
        public string Email;
        public string Address;

        public void Information(string fName, string email, string address)
        {
            FirstName = fName;
            Email = email;
            Address = address;

            
        }
        public void Information(int a, int b, int c)
        {
            var calculator = a + b + c;
            Console.WriteLine("Ther sum is = {0}", calculator);
        }
        public void Display()
        {
            Console.WriteLine("First Name:  {0}", FirstName);
            Console.WriteLine("Email: {0}", Email);
            Console.WriteLine("Address: {0}", Address);

        }
        //31 
        public string CompanyName;
        public string CEmail;
        public string CAddress;

        public string CompanyInfo(string cName, string cEmail, string cAddress)
        {
            CompanyName = cName;
            CEmail = cEmail;
            CAddress = cAddress;

            return "Honesty Is the best Policy";
        }

        public void CDisplay()
        {
            Console.WriteLine("Company Name:  {0}", CompanyName);
            Console.WriteLine("Company Email: {0}", CEmail);
            Console.WriteLine("Company Address: {0}", CAddress);

        }

        //32
        public int PrintallOdd(int b)
        {
            for(int a = 0; a < b; a++)
            {
                if(a % 2 != 0)
                {
                    Console.WriteLine("Odd = {0}", a);
                }
                else
                    Console.WriteLine();
            }
            return b;
        }
        //33
        public int PrintAllEven(int n)
        {
            for(int i = 0; i <= n; i++)
            {
                if(i % 2 == 0)
                    Console.WriteLine("Even = {0}", i);
                else
                    Console.WriteLine();
            }
            return n;
        }
        //34
        public bool DoYouWant(int a )
        {
            if (a == 1)
                return true;
            else if (a == 2)
                return false;
            else
                return false;
        }
        //35
        public void Nothing()
        {
            Console.WriteLine("Return type method");
        }
        //36
        public double DSum(double a, double b)
        {
            return a + b;
        }
        //37
        private string intLengths(int a, string b)
        {
            if (a.GetType() == b.GetType())
                return "This two values data type are equal";
            else
                return "Data type are not equal";
        }
        //38

        public int sumInt(int a, int b, int c)
        {
            return a + b + c;
        }

        //39
        public bool IsItValid(string a, string b)
        {
            var c = a + b;
            Console.WriteLine(c);
            return true;
        }
        //40
        protected void NoReturntype(int a, int b)
        {
            int sum = a + b;
        }
        //41
        public void Names()
        {
            string firstName = "hasan";
            string lastName = "hasib";
            Console.WriteLine($"{firstName}, {lastName} ");
        }
        //42
        public string StdInfo(string FullName, string Email, string Address)
        {
            Console.WriteLine(FullName);
            Console.WriteLine(Email);
            Console.WriteLine(Address);

            return "Submitted";
        }
        //43
        public float divFloat(float a, float b, int c)
        {
            var div = (a + b) / c;
            Console.WriteLine(div);
            return 4.555f;
        }
        //44
        public string Sumfloat(float a, float b)
        {
            var sum = a + b;
            Console.WriteLine(sum);
            return "Floating";
        }
        //45
        private float MulFloat(float a, float b)
        {
            return a * b;
        }
        //46 
        internal double SumDouble(double a, double b)
        {
            return a + b;
        }
        //47
        public double Calculate(double a, double b, double c)
        {
            var cal = (a + b) / c;
            Console.WriteLine(cal);
            return 12.45;
        }
        //48
        protected double Equations()
        {
            return 4555.66;
        }
        //49 
        private double MulDouble(double a, double c, double d)
        {
            return 3.5 + a + c + d;
        }
        //50

        


    }
}
