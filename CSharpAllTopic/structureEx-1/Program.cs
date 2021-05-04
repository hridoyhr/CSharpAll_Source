using System;

namespace structureEx_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.GetBook("C# Programming","Jhon Dee","C#",239);
            book1.Display();
        }
    }
}
