// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


/*int m = 3; // Количество строк
int n = 4; // Количество столбцов

        double[,] array = new double[m, n]; // Создание двумерного массива

        Random random = new Random();

        // Заполнение массива случайными вещественными числами
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                array[i, j] = random.NextDouble();
            }
        }

        // Вывод массива на консоль
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
*/

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
/*
int[,] array = {
            { 1, 4, 7, 2 },
            { 5, 9, 2, 3 },
            { 8, 4, 2, 4 }
        };

        Console.Write("Введите номер строки: ");
        int row = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите номер столбца: ");
        int column =  Convert.ToInt32(Console.ReadLine());

        int rows = array.GetLength(0);
        int columns = array.GetLength(1);

        if (row >= 0 && row < rows && column >= 0 && column < columns)
        {
            int element = array[row, column];
            Console.WriteLine("Значение элемента: " + element);
        }
        else
        {
            Console.WriteLine("Такого элемента нет в массиве.");
        }
   
*/
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
/*

int[,] array = {
            { 1, 4, 7, 2 },
            { 5, 9, 2, 3 },
            { 8, 4, 2, 4 }
        };

        int rows = array.GetLength(0);
        int columns = array.GetLength(1);

        double[] columnAverages = new double[columns];

        // Вычисление среднего арифметического для каждого столбца
        for (int j = 0; j < columns; j++)
        {
            double columnSum = 0;

            for (int i = 0; i < rows; i++)
            {
                columnSum += array[i, j];
            }

            columnAverages[j] = columnSum / rows;
        }

        // Вывод среднего арифметического для каждого столбца
        Console.WriteLine("Среднее арифметическое каждого столбца:");
        for (int j = 0; j < columns; j++)
        {
            Console.WriteLine(columnAverages[j].ToString("0.0"));
        }
   */

//  Дополнительное:
// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12  
/*
        int[,] array = {
            { 1, 4, 7, 2 },
            { 5, 9, 2, 3 },
            { 8, 4, 2, 4 }
        };

        int rows = array.GetLength(0);
        int columns = array.GetLength(1);

        int diagonalSum = 0;

        // Вычисление суммы элементов на главной диагонали
        for (int i = 0; i < Math.Min(rows, columns); i++)
        {
            diagonalSum += array[i, i];
        }

        // Вывод суммы элементов на главной диагонали
        Console.WriteLine("Сумма элементов на главной диагонали: " + diagonalSum);

*/