void InputMatrix(int[,] mtrx)
{
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            mtrx[i, j] = new Random().Next(1, 21);
            Console.Write($"{mtrx[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void FindMinElement(int[,] mtrx)
{
    int minValue = mtrx[0, 0], minRow = 0, minColumn = 0;
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            if (mtrx[i, j] < minValue)
            {
                minValue = mtrx[i, j];
                minRow = i;
                minColumn = j;
            }
        }
    }
    Console.WriteLine($"Минимум равный {minValue} находится на позиции: [{minRow+1},{minColumn+1}]");
    Console.WriteLine();
    Console.WriteLine("Конечный массив:");
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        if (i != minRow)
        {
            for (int j = 0; j < mtrx.GetLength(1); j++)
            {
                if (j != minColumn)
                Console.Write($"{mtrx[i,j]}\t");
            }
            Console.WriteLine();
        }
    }
}

Console.Write("Введите число строк и столбцов через пробел: ");
int[] matrixSize = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[matrixSize[0], matrixSize[1]];

InputMatrix(matrix);
Console.WriteLine();

FindMinElement (matrix);
