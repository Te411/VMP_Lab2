//Даны две матрицы размерами 3*3. 
//Структура хранения элементов матриц – одномерный массив, 
//первые 100 000 элементов это первая строка матрица, 
//следующие 100 000 элементов это вторая строка матрицы и т.д. 
//Выполнить умножение матриц и результат записать в третью матрицу

using System;
namespace Program
{
    class Project
    {
        static void Main()
        {
            Random rnd = new Random();
            int m = 0, k = 0, N = 1000, count = 0;
            int[] matrix1 = new int[N * N];
            int[] matrix2 = new int[N * N];
            int[] matrix3 = new int[N * N];


            for (int i = 0; i < matrix1.Length; i++)
            {
                matrix1[i] = rnd.Next(0, 100);
            }
            Console.Write("Матрицы 1: ");
            Console.WriteLine();
            for (int i = 0; i < matrix1.Length; i++)
            {
                Console.Write($"{matrix1[i]} ");
                if ((i + 1) % N == 0)
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine();


            for (int i = 0; i < matrix1.Length; i++)
            {
                matrix2[i] = rnd.Next(0, 100);
            }
            Console.Write("Матрицы 2: ");
            Console.WriteLine();
            for (int i = 0; i < matrix2.Length; i++)
            {
                Console.Write($"{matrix2[i]} ");
                if ((i + 1) % N == 0)
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine();

            for (int i = 0; i < N * N; i += N)
            {
                while (k != 3)
                {
                    for (int j = i; j < N + i; j++)
                    {
                        if (m < N * N)
                        {
                            matrix3[count] += matrix1[j] * matrix2[m];
                            m += N;
                        }
                    }
                    count++;
                    k++;
                    m = k;
                }
                m = 0;
                k = 0;
            }

            Console.Write("Матрица 1 * Матрицу 2: ");
            Console.WriteLine();
            for (int i = 0; i < matrix3.Length; i++)
            {
                Console.Write($"{matrix3[i]} ");
                if ((i + 1) % N == 0)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
