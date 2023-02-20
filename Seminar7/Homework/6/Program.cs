

void FillMatrix(double[,] anyMatrix)
{
    int k = 1;
    for (int i = 0; i < anyMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < anyMatrix.GetLength(1); j++)
        {
            anyMatrix[0, 0] = 0;
            anyMatrix[i, j] = anyMatrix[i, j] + 1;

            if (j - k == 0)
            {
                i = i + k;
                j = j - k;
                k++;
            }
            
            if (j + k > anyMatrix.GetLength(1))
            {
                i = i + 1;
                j = k;
            }
        }
    }
}

    void PrintMatrix(double[,] anyMatrix)
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
    double[,] matrix = new double[size[0], size[1]];

    FillMatrix(matrix);
    PrintMatrix(matrix);