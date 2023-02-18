// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void FillMatrix(double [,] anyMatrix)
{
    for (int i = 0; i < anyMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < anyMatrix.GetLength(1); j++)
        {
            anyMatrix[i,j] = Math.Round(new Random().NextDouble() * (i*3 - j*5) + j, 2);
        }
    }
}

void PrintMatrix (double [,] anyMatrix)
{
    for (int i = 0; i < anyMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < anyMatrix.GetLength(1); j++)
        {
            Console.Write($"{anyMatrix[i,j]}\t");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите через пробел количество строк и столбцов матрицы: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
double[,] matrix = new double[size[0], size[1]];

FillMatrix(matrix);
PrintMatrix(matrix);