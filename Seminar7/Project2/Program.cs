﻿void FillMatrix(int[,] mtrx)
{
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            mtrx[i, j] = i + j;
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

void PrintOddMatrix(int[,] mtrx)
{
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            if (i % 2 != 0 && j % 2 != 0)
            {
                mtrx[i, j] = mtrx[i, j] * mtrx[i, j];
            }
        }
    }
}
Console.Write("Введите через пробел количество строк и столбцов матрицы: ");

int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

int[,] matrix = new int[size[0], size[1]];

FillMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
PrintOddMatrix(matrix);
PrintMatrix(matrix);
