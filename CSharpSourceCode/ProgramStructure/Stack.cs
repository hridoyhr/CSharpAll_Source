using DocumentFormat.OpenXml.Vml.Office;
using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramStructure
{
    public class Stack<T>
    {
        Entry _top;
    }

    public void Push(T data)
    {
         _top = new Entry(_top, data);
    }

    public T Pop()
    {
        if(_top == null)
        {
            throw new InvalidOperationException();
        }
        T result = _top.Data;
        _top = _top.Next;

        return result;
    }

    class Entry
    {
        public Entry Next { get; set; }
        public T Data { get; set; }

        public Entry(Entry next, Task data)
        {
            Next = next;
            Data = data;
        }
    }
}
