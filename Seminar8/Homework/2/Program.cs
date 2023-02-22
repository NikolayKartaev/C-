// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void InputMatrixPrint(int[,] mtrx)
{
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            mtrx[i, j] = new Random().Next(1, 31);
            Console.Write($"{mtrx[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int FindMinSum(int[,] anyMatrix)
{
    int[] anyArray = new int[anyMatrix.GetLength(0)];
    for (int i = 0; i < anyMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < anyMatrix.GetLength(1); j++)
        {
            anyArray[i] += anyMatrix[i, j];
        }
    }
    int min = anyArray[0], minPos = 0;
    for (int k = 0; k < anyMatrix.GetLength(0); k++)
    {
        if (anyArray[k] < min)
        {
            min = anyArray[k];
            minPos = k;
        }
    }
    Console.WriteLine($"Сумма элементов каждой строки: {string.Join(", ", anyArray)}");
    return minPos;
}

Console.Clear();
Console.Write("Введите количество строк и столбцов через пробел: ");
int[] matrixSize = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[matrixSize[0], matrixSize[1]];

InputMatrixPrint(matrix);
Console.WriteLine();
Console.Write($"Номер строки с наименьшей суммой элементов: {FindMinSum(matrix)+1} строка");