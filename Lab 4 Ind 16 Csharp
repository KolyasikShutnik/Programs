using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace Lab_4_Ind_16_Csharp
{
    class Program
    {
        static void Main()
        {
            double r, pi, x, y, s, a, p, d, ch, zn;
            int n, k;
            m1: Console.WriteLine(" Введіть значення кута в радіанах без Пі");
            r = double.Parse((Console.ReadLine()));
            pi = Math.PI;
            x = r * pi;
            Console.WriteLine('\t' + "Проміжні результати" + '\n');
            k = 0; s = 0; p = 1; n = 2; d = 1;
            a = 1;
            while (Math.Abs(a) >= 0.000001)
            {
                s += a;
                ch = 2 * 2 * x * x * d;
                p = -p * (n - 1) * n;
                zn = p;
                a = ch / zn;
                d = 2 * 2 * x * x;
                n += 2;
                k++;
                Console.WriteLine('\t' + " Ітерація № " + k + '\n' + " a = " + a + " s = " + s + '\n');
            }
            y = Math.Cos(2 * x);
            Console.WriteLine('\t' + "РЕЗУЛЬТАТИ:" + '\n'
            + " Значення кута в радіанах = " + r + " Пі" + '\n'
            + " Сума ряду = " + s + '\n'
            + " Кількість членів ряду = " + k + '\n'
            + " Функція cos(2x) = " + y + '\n');
            Console.WriteLine('\n' + " Для повторного вводу "
            + "натисніть будь-яку кнопку" + '\n'
            + " Для завершення програми натисніть Enter");
            string rep = Console.ReadLine();
            if (rep != "") goto m1;
        }
    }
}
