// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такой позиции в массиве нет
// 1 2 -> На данной позиции находиться элемент 4

string FindElement(int[,] mtrx, int[] pos)
{
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            if (pos[0] > mtrx.GetLength(0) || pos[1] > mtrx.GetLength(1))
            return "такой позиции в массиве нет";
        }
    }
    return Convert.ToString($"На данной позиции находиться элемент {mtrx[pos[0] - 1, pos[1] - 1]}");
}

void FillMatrix(int[,] mtrx)
{
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            mtrx[i, j] = new Random().Next (-5,16);
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
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
Console.WriteLine();

FillMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();

Console.Write("Введите через пробел номер строки и номер столбца: ");
int[] position = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
Console.WriteLine();


Console.WriteLine(FindElement(matrix, position));