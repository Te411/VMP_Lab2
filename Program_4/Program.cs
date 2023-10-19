//Задача 4. В кинотеатре n рядов по m мест в каждом. 
//В двумерном массиве хранится информация о проданных билетах, 
//число 1 означает, что билет на данное место уже продано, 
//число 0 означает, что место свободно. 
//Поступил запрос на продажу k билетов на соседние места в одном ряду. 
//Определите, можно ли выполнить такой запрос.
using System;

namespace Program
{
    class Project
    {
        static void Main()
        {
            Random rnd = new Random();
            int m = 0, n = 0, k = 0, count = 0, count1 = 0, row = 0;

            Console.Write("Введите количество рядов в кинотеатре (от 0 до 127): ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            while (n < 0 || n > 127)
            {
                Console.WriteLine("Количество рядов должно быть от 0 до 127!");
                Console.Write("Введите еще раз: ");
                n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            }

            Console.Write("Введите количество мест в одном ряду (от 0 до 127): ");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            while (m < 0 || m > 127)
            {
                Console.WriteLine("Количество мест должно быть от 0 до 127!");
                Console.Write("Введите еще раз: ");
                m = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            }
            int[,] matrix = new int[n, m];

            Console.WriteLine("Информация о проданных билетах (0- свободно, 1 - продано): ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = rnd.Next(0, 2);
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.Write("Введите количество билетов для покупки (на соседние места): ");
            k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            while (k < 0 || k > 127)
            {
                Console.WriteLine("Количество мест должно быть от 0 до 127!");
                Console.Write("Введите еще раз: ");
                k = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        count++;
                        if (count == k)
                        {
                            count1 = 1;
                            if (row == 0)
                            {
                                row = i + 1;
                            }
                        }
                    }
                    else
                    {
                        count = 0;
                    }
                }
                count = 0;
            }

            if (count1 == 1)
            {
                Console.WriteLine("Запрос выполнить можно");
                Console.WriteLine($"Ряд {row}");
            }
            else
            {
                Console.WriteLine("Запрос нельзя выполнить");
            }



        }
    }
}
