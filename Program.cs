using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace Lab_2_Csharp
{
    class Program
    {
        public static void Main()
        {
            float a;
            int i;
            float c;
            bool l;
            string n;
            Console.WriteLine("Input прізвище");
            n = Console.ReadLine();
            Console.WriteLine("Input a");
            a = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Input i");
            i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input c");
            c = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Input l");
            l = Convert.ToBoolean(Console.ReadLine());
            System.Console.WriteLine("Результати форматування \nn = {0, 6}, l = {1, 4}", n, l);
            System.Console.WriteLine("a = {0, 4}, c = {1, 10:f5}, i = {2, 20:e8}", a, c, i);
            System.Console.WriteLine(" ");
            System.Console.WriteLine("Для виходу натисніть Enter");
            System.Console.ReadLine();
        }
    }
}
