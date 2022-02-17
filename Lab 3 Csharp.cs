using System;

namespace Lab_3_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            float f;
            float max;
            float min;
            m: Console.WriteLine("Введіть значення X");
            float x = float.Parse((Console.ReadLine()));
            Console.WriteLine("Введіть значення Y");
            float y = float.Parse((Console.ReadLine()));
            Console.WriteLine("Введіть значення Z");
            float z = float.Parse((Console.ReadLine()));
            max = x * x * x;
            if (y * y > max) max = y * y;
            if (x * y > max) max = x * y;
            min = x;
            if (y * z < min) min = y * z;
            if (min * min - y == 0) Console.WriteLine('\n' + "Неможна ділити на нуль");
            else
            {
                f = (max + x) / (min * min - y);
                Console.WriteLine('\n' + "Дано: X = " + x + " Y = " + y + " Z = " + z + '\n' + "Результат: F = " + f);
            }
            Console.WriteLine('\n' + "Для повторного введення натисніть будь-яку клавішу." + '\n' + "Для завершення програми натисніть Enter.");
            string p = Console.ReadLine();
            if (p != "") goto m;
        }
    }
}
