using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace Lab_4_Csharp
{
    class Program
    {
        static void Main()
        {
            StreamWriter p = new StreamWriter(@"C:\Users\Калясик\Desktop\rez.txt");
            float a, x, y;
            p.WriteLine(" РЕЗУЛЬТАТИ РОЗРАХУНКУ");
            for (a = 0.5f; a <= 1.25f; a += 0.25f)
            {
                p.WriteLine(" a = " + a);
                for (x = 0; x <= 3; x += 0.1f)
                {
                    y = (float)(Math.Atan(x / (2 * a)) / (x * x + 2 * a));
                    p.WriteLine(" x = " + x + '\t' + "y = " + y);
                }
            }
            p.Close();
        }
    }
}
