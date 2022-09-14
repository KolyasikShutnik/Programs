using System;

namespace Lab_1_OOP_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            A Obj = new A();
            Console.WriteLine($" c = {Obj.C}");
        }
    }
    class A
        {
            float a = 2.5f;
            float b = 4.5f;
            float c;
            public float C
            {
                get { return (a *= b) - b; } // a = a * b; a - b
                set { c = value; } // c = a * b - b
            }
        }
}
