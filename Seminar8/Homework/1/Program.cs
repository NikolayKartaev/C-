// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы
// каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
void MatrixInput(int[,] mtrx)
{
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            mtrx[i, j] = new Random().Next(1,101);
            Console.Write($"{mtrx[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void MatrixChangePrint(int[,] mtrx)
{

    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            int maxColumn = j;
            for (int k = j+1 ; k < mtrx.GetLength(1); k++)
            {
                if (mtrx[i, k] > mtrx[i, maxColumn])
                maxColumn = k;
            }
            int temp = mtrx[i, j];
            mtrx[i, j] = mtrx[i, maxColumn];
            mtrx[i, maxColumn] = temp;
            Console.Write($"{mtrx[i, j]}\t");
        }
        Console.WriteLine();
    }
}
Console.Clear();

Console.Write("Введите количество строк и столбцов двумерного массива: ");
int[] matrixSize = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
Console.WriteLine();

int[,] matrixA = new int[matrixSize[0], matrixSize[1]];
Console.WriteLine("Задан двумерный массив: ");

MatrixInput(matrixA);
Console.WriteLine();
MatrixChangePrint(matrixA);
