using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace Lab_2_Ind_16_Csharp
{
    class Program
    {
        static void Main()
        {
            string s;
            double x, y;
            StreamWriter f = new StreamWriter(@"C:\Users\Калясик\Desktop\LAB2.RES.txt");
            StreamReader f1 = new StreamReader(@"C:\Users\Калясик\Desktop\LAB2.TXT.txt");
            f.WriteLine("      Отримано: \n");
            metka: s = f1.ReadLine();
            if (s == null) goto metka1;
            x = Convert.ToDouble(s);
            y = x * x  - 3 * Math.Sin(x);
            f.WriteLine("      для заданої функції Y({0:F3}) = {1:e3} \n", x, y);
            goto metka;
            metka1: f.WriteLine("      Склав: <Шутко Микола Володимирович> {0} \n", s);
            f.Close();
            f1.Close();
        }
    }
}
