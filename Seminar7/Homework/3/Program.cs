// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


void FillMatrix(int[,] mtrx)
{
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            mtrx[i, j] = new Random().Next(1, 11);
        }
    }
}

void PrintMatrix(int[,] mtrx)
{
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            Console.Write($"{mtrx[i, j]}\t");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите через пробел количество строк и столбцов матрицы: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
Console.WriteLine();

FillMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();

void FindAverage(int[,] mtrx, double[] average)
{
    for (int j = 0; j < mtrx.GetLength(1); j++)
    {
        for (int i = 0; i < mtrx.GetLength(0); i++)
        {
            average[j] += mtrx[i, j];
        }
        average[j] = Math.Round(average[j]/mtrx.GetLength(0), 2);
    }
}

double[] array = new double[matrix.GetLength(1)];
FindAverage(matrix, array);
Console.Write($"Среднее арифметическое каждого столбца: {string.Join(", ", array)}");