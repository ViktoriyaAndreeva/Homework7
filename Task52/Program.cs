namespace Homework7
{
    class Task52
    {
        //  Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

        public static void Main()
        {
            Console.WriteLine("Введите количество строк");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"В массиве строк: {m}");
            Console.WriteLine("Введите количество столбцов");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"В массиве столбцов: {n}");

            int[,] array = new int[m, n];

            FillArray(array, m, n);
            PrintArray(array);
            FindAverage(array);
        }
        public static void FillArray(int[,] array, int m, int n)
        {
            Random array1 = new Random();
            int[,] array2 = new int[m, n];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = Convert.ToInt32(array1.Next(0, 10));

                }
            }
        }
        public static void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
        public static void FindAverage(int[,] array)
        {
            double sum = 0;
            double average = 0;
            int count = array.GetLength(0);
                              
            for (int i = 0; i < array.GetLength(1); i++)
            {
                sum = 0;
                for (int j = 0; j < array.GetLength(0); j++)
                {
                    sum = sum + array[j,i]; 
                }
                Console.WriteLine($"Сумма:{sum} + Кол-во строк:{count}");
                average = sum / count;
                Console.WriteLine($"Среднеарифметическое столбца {i+1}: {Math.Round(average, 2)} ");
                
            }
               
        }

    }
}