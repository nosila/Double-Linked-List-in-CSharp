using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Double_Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            DLL<int> lista = new DLL<int>();
            
            lista.AddFirst(1);
            lista.AddFirst(2);
            lista.AddFirst(4);
            lista.AddFirst(5);
            lista.AddFirst(6);
            lista.AddLast(100);

            Console.WriteLine(lista);
        }
    }
}
