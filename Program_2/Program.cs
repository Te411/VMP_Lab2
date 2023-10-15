using System;

namespace Program
{
    class Project
    {
        static void Main()
        {
            int N = 0;
            Console.Write("Введите размерность одномерного массива: ");
            N = Convert.ToInt32(Console.ReadLine());
            while (N < 1 || N > 10)
            {
                Console.Write("Введите размерность одномерного массива (от 1 до 10): ");
                N = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            int[] array = new int[N];
            Console.Write("Введите элементы для этого массива: ");
            Console.WriteLine();
            for (int i = 0; i < N; i++)
            {
                Console.Write($"Элемент #{i + 1}: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();

            for (int i = 0; i < N / 2; i++)
            {
                if (N % 2 == 0)
                {
                    int tmp = array[i];
                    array[i] = array[N / 2 + i];
                    array[N / 2 + i] = tmp;
                }
                else
                {
                    int tmp = array[i];
                    array[i] = array[N / 2 + i + 1];
                    array[N / 2 + i + 1] = tmp;
                }
            }
            Console.Write("Полученный массив: ");
            foreach (int i in array)
            {
                Console.Write($"{i} ");
            }
        }
    }
}