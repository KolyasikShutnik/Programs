using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Lab_1_Ind_2_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            double p = 3.14159;
            double x = 1.2;
            double e = 2.71828;
            double y = Math.Pow(x + 7.0 / 6.0, 4.0 / 3.0) + Math.Sin(Math.Pow(e, x)) + Math.Asin(Math.Cos(p * x));
            Console.WriteLine("Лабораторна робота 1");
            Console.WriteLine("Структура консольного додатку в С#");
            Console.WriteLine("Виконав: Шутко Микола Володимирович");
            Console.WriteLine("Група: ЕС-134Б");
            Console.WriteLine("Спеціальність: 171 Електроніка");
            Console.WriteLine(" x = {0} \t y = {1}", x, y);
            Console.ReadKey();
        }
    }
}
