void FillMatrix(int[,] mtrx)
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


Console.Write("Введите через пробел количество строк и столбцов матрицы: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];

FillMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();

int sum = 0;
int SumDiagonal(int[,] mtrx)
{
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            if (i==j) sum = sum + mtrx[i,j];
        }
        
    }
    return sum;
}
Console.WriteLine(SumDiagonal (matrix));
