// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void MatrixInput(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 7);
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void MatrixMultiply(int[,] firstmatrix, int[,] secondmatrix)
{
    int[,] resultmatrix = new int[firstmatrix.GetLength(0), secondmatrix.GetLength(1)];
    for (int i = 0; i < firstmatrix.GetLength(0); i++)
    {
        for (int k = 0; k < secondmatrix.GetLength(1); k++)
        {
            for (int j = 0; j < firstmatrix.GetLength(1); j++)
            {
                resultmatrix[i, k] += firstmatrix[i, j] * secondmatrix[j, k];
            }
            Console.Write($"{resultmatrix[i, k]}\t");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите количество строк и стобцов первой матрицы через пробел: ");
int[] sizeA = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
Console.Write("Введите количество строк и стобцов второй матрицы через пробел: ");
int[] sizeB = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
if (sizeA[1] != sizeB[0])
{
    Console.Write("Матрицы не совместимы. Введите количество строк и стобцов второй матрицы через пробел: ");
    sizeB = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
}

int[,] matrixA = new int[sizeA[0], sizeA[1]];
int[,] matrixB = new int[sizeB[0], sizeB[1]];
Console.WriteLine();

Console.WriteLine("Матрица А: ");
MatrixInput(matrixA);
Console.WriteLine();

Console.WriteLine("Матрица B: ");
MatrixInput(matrixB);
Console.WriteLine();

Console.WriteLine("Результат умножения матриц A и B: ");
MatrixMultiply(matrixA, matrixB);