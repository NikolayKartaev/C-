void FillMatrix(int[,] anyMatrix)
{
    for (int i = 0; i < anyMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < anyMatrix.GetLength(1); j++)
        {
            anyMatrix[i, j] = new Random().Next(1,21);
        }
    }
}

void PrintMatrix(int[,] anyMatrix)
{
    for (int i = 0; i < anyMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < anyMatrix.GetLength(1); j++)
        {
            Console.Write($"{anyMatrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите через пробел количество строк и столбцов матрицы: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];

FillMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();

void ChangeMatrix(int[,] mtrx)
{
    for (int i = 0; i < 1; i++) // цикл до 1, чтобы изменить только первую строку
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            int temp = mtrx[i, j];
            mtrx[i, j] = mtrx[mtrx.GetLength(0) - i - 1,j]; // меняем первую и последнюю строку массива
            mtrx[mtrx.GetLength(0) - i - 1,j] = temp;
        }
    }
}

ChangeMatrix (matrix);
PrintMatrix(matrix);
