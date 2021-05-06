using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample_1
{
    public class Person
    {
        private string name;
        public double Height;
        public double Wight;
        public string Address;
        public int speed;


        public string Name
        { 
            get
            {
                return name;
            }
            set
            {
                if(value != "")
                name = value;
            }
        }

        public Person()
        {

            Console.WriteLine("No Parametter");
        }

        public Person(string address)
        {
            Address = address;
        }


        public double  Walk()
        {
            return speed = 10;
        }

        public void Display()
        {
            Console.WriteLine("Name = {0}", Name);
            Console.WriteLine("Height = {0}", Height);
            Console.WriteLine("Weight = {0}", Wight);
            Console.WriteLine("Address = {0}", Address);
            Console.WriteLine("Speed = {0}",Walk());
        }
    }
}
