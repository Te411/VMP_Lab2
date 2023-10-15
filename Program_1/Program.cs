//Дан одномерный массив числовых значений, насчитывающий N элементов. Вставить группу из M новых элементов, начиная с позиции K.

using System;

namespace Project
{

    class Program
    {
        static void Main()
        {
            Console.Write("Введите размерность одномерного массива: ");
            int n = Convert.ToInt32(Console.ReadLine());
            while (n < 1 || n > 10)
            {
                Console.Write("Введите размерность одномерного массива (от 1 до 10): ");
                n = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            int[] numbers = new int[n]; // целочисленный массив на 5 элемнтов
            Console.Write("Введите элементы для этого массива: ");
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.Write("Элемент #{0}: ", i + 1);
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();


            Console.Write("Введите размерность группы новых элементов: ");
            int m = Convert.ToInt32(Console.ReadLine());
            while (m < 1 || m > 10)
            {
                Console.Write("Введите размерность группы новых элементов (от 1 до 10): ");
                m = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();

            int[] newElements = new int[m]; // группа из M элементов для вставки

            Console.Write("Введите элементы для этой группы: ");
            Console.WriteLine();
            for (int i = 0; i < m; i++)
            {
                Console.Write("Элемент #{0}: ", i + 1);
                newElements[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();


            int K = 0; // позиция
            Console.Write("Введите позицию с которой нужно сделать вставку: ");
            K = Convert.ToInt32(Console.ReadLine());
            while (K < 0 || K > numbers.Length)
            {
                Console.Write("Введите позицию с которой нужно сделать вставку(от 0 до {0}): ", numbers.Length);
                K = Convert.ToInt32(Console.ReadLine());
            }


            Array.Resize(ref numbers, n + m);

            Array.Copy(numbers, K - 1, numbers, K - 1 + n, n - K + 1); // сдвиг элементов
            Array.Copy(newElements, 0, numbers, K - 1, m); // вставка новых элементов

            Console.Write("\nИтоговый массив: ");
            foreach (int i in numbers)
            {
                Console.Write(" {0}", i);
            }
            Console.WriteLine();
        }
    }
}