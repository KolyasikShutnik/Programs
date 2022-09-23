using System;

namespace Lab_2_OOP_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Введіть кількість кафедр");
            int n = Convert.ToInt32(Console.ReadLine());
            string k1;
            int p1;
            int f1;
            int sp = 0;
            int sf = 0;
            Kafedra[] ArrayOfObjects = new Kafedra[n]; // Створення масиву об'єктів класу Kafedra
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(" Введіть назву кафедри");
                k1 = Convert.ToString(Console.ReadLine());
                Console.WriteLine(" Введіть кількість годин використання машинного часу за планом");
                p1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" Введіть кількість годин використання машинного часу фактично");
                f1 = Convert.ToInt32(Console.ReadLine());
                ArrayOfObjects[i] = new Kafedra(k1, p1, f1); // Створення елемента масиву - об'єкта класу Kafedra
                sp += p1;
                sf += f1;
            }
            Console.WriteLine(" №   Кафедра Використання машинного часу, годин Відхилення від плану");
            Console.WriteLine(" з/п         за планом         фактично         у годинах у %       ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"  {i + 1,2}  {ArrayOfObjects[i].K,6} {ArrayOfObjects[i].P,16}  {ArrayOfObjects[i].F,16}   {ArrayOfObjects[i].O1,8}  {ArrayOfObjects[i].O2,8}"); // Виведення елементів масиву - об'єктів класу Kafedra
            }
            Console.WriteLine($"     Разом   {sp,16}  {sf,16}");
        }
    }
    class Kafedra
    {
        string k;
        int p;
        int f;
        int o1;
        int o2;
        public Kafedra(string k1, int p1, int f1) // Конструктор
        {
            this.k = k1;
            this.p = p1;
            this.f = f1;
            o1 = p1 - f1;
            o2 = o1 * 100 / p1;
        }
        public string K
        {
            get { return k; }
            set { k = value; }
        }
        public int P
        {
            get { return p; }
            set { p = value; }
        }
        public int F
        {
            get { return f; }
            set { f = value; }
        }
        public int O1
        {
            get { return o1; }
            set { o1 = value; }
        }
        public int O2
        {
            get { return o2; }
            set { o2 = value; }
        }
    }
}
