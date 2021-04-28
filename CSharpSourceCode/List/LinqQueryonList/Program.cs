using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqQueryonList
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>()
            {
                new Student(){ID = 1, Name = "Bill"},
                new Student(){ID = 2, Name = "Hasan"},
                new Student(){ID = 3, Name = "Hardik"},
                new Student(){ID = 4, Name = "Rony"},

            };

            var result =
                from student in students
                where student.ID > 2
                select student;
            foreach(var student in students)
                Console.WriteLine(student.Name);

            var number = new List<int>() { 10, 30, 22, 11};
            number.Insert(0, 500);


            

            

        }
    }
}
