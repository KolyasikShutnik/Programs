using System;

namespace Lab_3_Ind_16_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            m: Console.WriteLine("Введіть для точки М координату X");
            float x = float.Parse((Console.ReadLine()));
            Console.WriteLine("Введіть для точки М координату Y");
            float y = float.Parse((Console.ReadLine()));
            if (((x < 0) && (y > 0)) || ((x > 0) && (y < 0))) N = 3;
            else
            {
                if (y - 1 / x > 0) N = 1;
                else N = 2;
            }
            Console.WriteLine('\n' + "Результат:");
            Console.WriteLine("Точка M(" + x + ";" + y + ")" + " лежить в області N = " + N);
            Console.WriteLine('\n' + "Для повторного введення натисніть будь-яку клавішу." + '\n' + "Для завершення програми натисніть Enter.");
            string p = Console.ReadLine();
            if (p != "") goto m;
        }
    }
}
