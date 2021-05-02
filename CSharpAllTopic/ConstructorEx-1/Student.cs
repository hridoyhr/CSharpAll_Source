using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorEx_1
{
    public class Student
    {
        public string Name;

        public Student(string name)
        {
            Console.WriteLine("Hello");
            Name = name;
        }

        public void setName(string name)
        {
            Name = name;
        }
        public string getName()
        {
            return Name;
        }
    }
}
