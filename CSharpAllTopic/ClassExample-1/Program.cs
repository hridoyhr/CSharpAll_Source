using System;

namespace ClassExample_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "";
            person.Height = 5.7;
            person.Wight = 65;
            person.Address = "Dhaka";

            person.Display();
            
        }
    }
}
