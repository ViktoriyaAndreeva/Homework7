namespace Homework7
{
    class Task47
    {
        // Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9
        public static void Main()
        {
            int m = new Random().Next(1, 10);
            Console.WriteLine($"Количество строк: {m}"); 
            int n = new Random().Next(1, 10); 
            Console.WriteLine($"Количество столбцов: {n}"); 
            double[,] array = new double[m, n];  

            FillArray(array, m, n);
            PrintArray(array);
        }
        public static void FillArray(double[,] array, int m, int n)
        {
            Random array1 = new Random();
            double[,] array2 = new double[m,n];

            for(int i = 0; i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = Convert.ToDouble(array1.Next(-100,100) / 10.0);
                    
                }
            } 
        }
        public static void PrintArray(double[,] array)
        {
            for(int i = 0; i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i,j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}    