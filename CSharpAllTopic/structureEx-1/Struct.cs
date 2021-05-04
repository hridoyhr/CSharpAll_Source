using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structureEx_1
{
    struct Book
    {
        public string Title;
        public string Author;
        public string Subject;
        public int Id;

        
        public void  GetBook(string title,string author,string sub, int id)
        {
            Title = title;
            Author = author;
            Subject = sub;
            Id = id;
        }
        
        public void Display()
        {
            Console.WriteLine("Title = {0}", Title);
            Console.WriteLine("Author = {0}", Author);
            Console.WriteLine("Subject = {0}", Subject);
            Console.WriteLine("ID = {0}", Id);
        }
    }
}
