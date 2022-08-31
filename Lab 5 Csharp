using System;

namespace Lab_5_Csharp
{
    class Program
    {
        static void Main()
        {
            int N = 10;
            int jAA = 0, jBB = 0, jCC = 0;
            int j;
            int k = 0;
            string strValue;
            int[] iArray = new int[N];
            int[] jA = new int[N];
            int[] jB = new int[N];
            int[] jC = new int[N];
            for (j = 0; j < N; j++)
            {
                strValue = Console.ReadLine();
                iArray[j] = Convert.ToInt32(strValue);
            }
            Console.WriteLine("\n Вхідний масив \n\n");
            foreach (int jj in iArray)
            Console.Write(" " + jj);
            Console.WriteLine("\n\n");
            for (j = 0; j < N; j++)
            {
                if (iArray[j] > 0)
                {
                    jA[jAA] = iArray[j];
                    jAA += 1;
                }
                if (iArray[j] == 0)
                {
                    jB[jBB] = iArray[j];
                    jBB += 1;
                }
                if (iArray[j] < 0)
                {
                    jC[jCC] = iArray[j];
                    jCC += 1;
                }
            }
            for (j = 0; j < jAA; j++)
            {
                iArray[j] = jA[k];
                k += 1;
            }
            k = 0;
            for (j = jAA; j < jAA + jBB; j++)
            {
                iArray[j] = jB[k];
                k += 1;
            }
            k = 0;
            for (j = jAA + jBB; j < N; j++)
            {
                iArray[j] = jC[k];
                k += 1;
            }
            Console.WriteLine("\n Відсортований масив \n\n");
            foreach (int jj in iArray)
            Console.Write(" " + jj);
            Console.WriteLine("\n\n");
        }
    }
}
