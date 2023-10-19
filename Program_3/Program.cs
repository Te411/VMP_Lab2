//Задача 3. Реализовать проект – операций над массивами, каждая подзадача реализуется в виде отдельной функции:
// -инициализация массива с помощью датчика случайных чисел. Размер массива определяет пользователь
// - сложение массивов поэлементно в случае равенства длины массивов
// - умножение массива на число осуществляется поэлементно
// - поиск общих значений двух массивов (длины массивов могут быть разные)
// -печать значений массива
// - упорядочивание значений массива по убыванию (без использования стандартных функций)
// -поиск min, max значение в массиве, среднего значения всех значений массива (без использования стандартных функций)

using System;

namespace Program
{
    class Project
    {
        static Random rnd = new Random();
        static int[] init()
        {
            sbyte N = 0;
            Console.Write("Выберите размерность массива: ");
            N = Convert.ToSByte(Console.ReadLine());
            Console.WriteLine();
            while (N < 0 || N > 50)
            {
                Console.WriteLine("Размерность массива должна быть от 0 до 50");
                Console.Write("Введите еще раз: ");
                N = Convert.ToSByte(Console.ReadLine());
            }
            Console.WriteLine();
            int[] array = new int[N];

            for (int i = 0; i < N; i++)
            {
                array[i] = rnd.Next(-100, 100);
            }
            return array;
        }

        static void SumArray(int[] array1, int[] array2)
        {
            if (array1 == null || array2 == null)
            {
                Console.WriteLine("Один или несколько массивов не инициализированы!");
                Console.WriteLine("Сначала нужно инициализировать массивы.");
                Console.WriteLine();
            }
            else if (array1.Length != array2.Length)
            {
                Console.WriteLine("Длины массиво должны совпадать!");
                Console.WriteLine($"В данном случае длина первого равна {array1.Length}, а длина второго {array2.Length}.");
                Console.WriteLine();
            }
            else
            {
                Console.Write("Массив номер 1: ");
                PrintArray(array1);
                Console.WriteLine();
                Console.Write("Массив номер 2: ");
                PrintArray(array2);
                Console.WriteLine("\n");
                int[] SumArray = new int[array1.Length];
                for (int i = 0; i < SumArray.Length; i++)
                {
                    SumArray[i] = array1[i] + array2[i];
                }
                Console.WriteLine("Результат после сложения двух массивов: ");
                PrintArray(SumArray);
                Console.WriteLine("\n");

            }
        }

        static int[] MultArray(int[] array)
        {
            if (array == null)
            {
                Console.WriteLine("Массив не инициализирован!");
                Console.WriteLine("Сначала нужно инициализировать массив.");
                Console.WriteLine();
                return array;

            }

            Console.Write("Выберите число на которое хотите умножить массив: ");
            sbyte number = Convert.ToSByte(Console.ReadLine());
            Console.WriteLine();
            while (number < 0 || number > 100)
            {
                Console.WriteLine("Число должно быть от 0 до 100");
                Console.Write("Введите еще раз: ");
                number = Convert.ToSByte(Console.ReadLine());
            }

            Console.Write("Вы умножаете массив (");
            PrintArray(array);
            Console.WriteLine($") на число {number}.");
            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array[i] * number;
            }
            Console.Write("Результат умножения: ");
            PrintArray(array);
            Console.WriteLine("\n");

            return array;
        }
        static void PrintArray(int[] array)
        {
            if (array == null)
            {
                Console.WriteLine();
                Console.WriteLine("Массив не инициализирован!");
                Console.WriteLine("Сначала нужно инициализировать массив.");
                Console.WriteLine();
            }
            else
            {

                foreach (int i in array)
                {
                    Console.Write($"{i} ");
                }
            }
        }

        static void FindElem(int[] array1, int[] array2)
        {
            Console.Write("Массив номер 1: ");
            PrintArray(array1);
            Console.WriteLine();
            Console.Write("Массив номер 2: ");
            PrintArray(array2);
            Console.WriteLine("\n");

            string result = "";
            foreach (int i in array1)
            {
                foreach (int j in array2)
                {
                    if (i == j)
                    {
                        result = i + " ";
                    }
                }
            }
            if (result == "")
            {
                Console.Write("Общих значений нет");
            }
            else
            {
                Console.Write($"Общие значения: {result}");
            }
            Console.WriteLine();
        }

        static int[] Sort(int[] array)
        {
            if (array == null)
            {
                Console.WriteLine("Этот массив не инициализирован!");
                Console.WriteLine("Сначала нужно инициализировать массив!");
                Console.WriteLine();
                return array;
            }
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i; j < array.Length; j++)
                {
                    if (array[j] > array[i])
                    {
                        int tmp = array[i];
                        array[i] = array[j];
                        array[j] = tmp;
                    }
                }
            }
            return array;
        }

        static void MinMaxAvg(int[] array)
        {
            if (array == null)
            {
                Console.WriteLine("Этот массив не инициализирован!");
                Console.WriteLine("Сначала нужно инициализировать массив!");
                Console.WriteLine();
            }
            else
            {
                int max = 0, min = 0, avg = 0, count = 0, sum = 0;
                foreach (int i in array)
                {
                    if (i > max)
                    {
                        max = i;
                    }
                    else if (i < min)
                    {
                        min = i;
                    }
                    count++;
                    sum += i;
                }
                avg = sum / count;
                Console.WriteLine($"Минимальное значение: {min}\nМаксимальное значение: {max}\n Среднее значение: {avg}");
            }
        }
        static void Main()
        {
            sbyte x = -1;
            sbyte count = 0;
            int[] array1 = null, array2 = null;
            do
            {
                Console.WriteLine("Выберите режим работы:");
                Console.WriteLine("1. Инициализация массива рандомом");
                Console.WriteLine("2. Сложение массивов");
                Console.WriteLine("3. Умножение массивов");
                Console.WriteLine("4. Поиск общих значений двух массивов");
                Console.WriteLine("5. Вывод значений массива");
                Console.WriteLine("6. Сортировка массива по убыванию");
                Console.WriteLine("7. Поиск min, max, среднего значений в массиве");
                Console.WriteLine("0. Завершение работы");
                x = Convert.ToSByte(Console.ReadLine());
                Console.WriteLine();
                while (x < 0 || x > 7)
                {
                    Console.WriteLine("Такого режима работы нет. Выберите еще раз.");
                    x = Convert.ToSByte(Console.ReadLine());
                }
                switch (x)
                {
                    case 1:
                        Console.WriteLine("Текущая информация о массивах:");
                        if (array1 == null)
                        {
                            Console.WriteLine("Массив номер 1 не инициализирован");
                        }
                        if (array2 == null)
                        {
                            Console.WriteLine("Массив номер 2 не инициализирован");
                        }

                        Console.WriteLine();
                        Console.WriteLine("Хотите инициализировать один из массивов?");
                        Console.Write("1 - да; 0 - нет  ");
                        count = Convert.ToSByte(Console.ReadLine());
                        Console.WriteLine();
                        while (count < 0 || count > 1)
                        {
                            Console.Write("1 - да; 0 - нет  ");
                            count = Convert.ToSByte(Console.ReadLine());
                        }

                        if (count == 1)
                        {
                            Console.WriteLine("Теперь выберите какой массив инициализировать: ");
                            Console.Write("1 - первый; 2 - второй; 3 - оба: ");
                            count = Convert.ToSByte(Console.ReadLine());
                            Console.WriteLine();
                            while (count < 0 || count > 3)
                            {
                                Console.Write("1 - первый; 2 - второй; 3 - оба:  ");
                                count = Convert.ToSByte(Console.ReadLine());
                                Console.WriteLine();
                            }
                            if (count == 1)
                            {
                                array1 = init();
                                Console.WriteLine("Массив номер 1 инициализирован");
                            }
                            else if (count == 2)
                            {
                                array2 = init();
                                Console.WriteLine("Массив номер 2 инициализирован");
                            }
                            else if (count == 3)
                            {
                                Console.WriteLine("Массив номер 1:");
                                array1 = init();
                                Console.WriteLine("Массив номер 2: ");
                                array2 = init();
                                Console.WriteLine("Массивы номер 1 и 2 инициализированы");
                            }
                        }
                        Console.WriteLine();
                        break;
                    case 2:
                        SumArray(array1, array2);
                        break;
                    case 3:
                        Console.WriteLine("Выберите массив, который хотите умножить");
                        Console.Write("1 - первый; 2 - второй; 3 - оба: ");
                        count = Convert.ToSByte(Console.ReadLine());
                        Console.WriteLine();
                        while (count < 0 || count > 3)
                        {
                            Console.Write("1 - первый; 2 - второй; 3 - оба:  ");
                            count = Convert.ToSByte(Console.ReadLine());
                            Console.WriteLine();
                        }
                        if (count == 1)
                        {
                            array1 = MultArray(array1);
                            
                        }
                        else if (count == 2)
                        {
                            array2 = MultArray(array2);
                            
                        }
                        else if (count == 3)
                        {
                            Console.WriteLine("Массив номер 1: ");
                            array1 = MultArray(array1);
                            Console.WriteLine("Массив номер 2: ");
                            array2 = MultArray(array2);
                           
                        }
                        Console.WriteLine("");
                        break;
                    case 4:
                        if (array1 == null || array2 == null)
                        {
                            Console.WriteLine("Один или несколько массивов не инициализированы!");
                            Console.WriteLine("Сначала нужно инициализировать массивы!");
                            Console.WriteLine();
                        }
                        else
                        {
                            FindElem(array1, array2);
                            Console.WriteLine();
                        }
                        break;
                    case 5:
                        Console.WriteLine("Выберите массив, который хотите вывести");
                        Console.Write("1 - первый; 2 - второй; 3 - оба: ");
                        count = Convert.ToSByte(Console.ReadLine());
                        Console.WriteLine();
                        while (count < 0 || count > 3)
                        {
                            Console.Write("1 - первый; 2 - второй; 3 - оба:  ");
                            count = Convert.ToSByte(Console.ReadLine());
                            Console.WriteLine();
                        }
                        if (count == 1)
                        {
                            Console.Write("Массив номер 1: ");
                            PrintArray(array1);
                        }
                        else if (count == 2)
                        {
                            Console.Write("Массив номер 2: ");
                            PrintArray(array2);
                        }
                        else if (count == 3)
                        {
                            Console.Write("Массив номер 1: ");
                            PrintArray(array1);
                            Console.WriteLine();
                            Console.Write("Массив номер 2: ");
                            PrintArray(array2);
                        }
                        Console.WriteLine("\n");
                        break;
                    case 6:
                        Console.WriteLine("Выберите массив, который хотите отсортировать");
                        Console.Write("1 - первый; 2 - второй; 3 - оба: ");
                        count = Convert.ToSByte(Console.ReadLine());
                        Console.WriteLine();
                        while (count < 0 || count > 3)
                        {
                            Console.Write("1 - первый; 2 - второй; 3 - оба:  ");
                            count = Convert.ToSByte(Console.ReadLine());
                            Console.WriteLine();
                        }
                        if (count == 1)
                        {
                            Console.Write("Массив номер 1: ");
                            Sort(array1);
                            Console.Write("отсортирован ");
                        }
                        else if (count == 2)
                        {
                            Console.Write("Массив номер 2: ");
                            Sort(array2);
                            Console.Write(" отсортирован ");
                        }
                        else if (count == 3)
                        {
                            Console.Write("Массив номер 1: ");
                            Sort(array1);
                            Console.Write("отсортирован ");
                            Console.WriteLine();
                            Console.Write("Массив номер 2: ");
                            Sort(array2);
                            Console.Write("отсортирован ");
                        }
                        Console.WriteLine("\n");
                        break;
                    case 7:
                        Console.WriteLine("Выберите массив, в котором хотите найти значения");
                        Console.Write("1 - первый; 2 - второй; 3 - оба: ");
                        count = Convert.ToSByte(Console.ReadLine());
                        Console.WriteLine();
                        while (count < 0 || count > 3)
                        {
                            Console.Write("1 - первый; 2 - второй; 3 - оба:  ");
                            count = Convert.ToSByte(Console.ReadLine());
                            Console.WriteLine();
                        }
                        if (count == 1)
                        {
                            Console.Write("Массив номер 1: ");
                            MinMaxAvg(array1);
                        }
                        else if (count == 2)
                        {
                            Console.Write("Массив номер 2: ");
                            MinMaxAvg(array2);
                        }
                        else if (count == 3)
                        {
                            Console.Write("Массив номер 1: ");
                            MinMaxAvg(array1);
                            Console.WriteLine();
                            Console.Write("Массив номер 2: ");
                            MinMaxAvg(array2);
                        }
                        Console.WriteLine("\n");
                        break;
                }
            } while (x != 0);
        }
    }
}