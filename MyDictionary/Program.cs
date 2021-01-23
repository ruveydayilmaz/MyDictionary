using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> grades = new MyDictionary<string, string>();

            grades.Add("Bessie", "A");
            grades.Add("Anna", "B");
            grades.Add("Harry", "F");

            Console.WriteLine("\t  Grade List");
            Console.WriteLine("\t ------------\n");
            grades.List();
        }
    }
}
