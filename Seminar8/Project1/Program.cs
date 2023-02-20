void FillMatrix(int[,] anyMatrix)
{
    for (int i = 0; i < anyMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < anyMatrix.GetLength(1); j++)
        {
            anyMatrix[i, j] = new Random().Next(1, 21);
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
while (size[0] != size[1])
{
    Console.Write("Вы ошиблись!\nВведите размер массива: ");
    size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
}

int[,] matrix = new int[size[0], size[1]];

FillMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();

void Transpon(int[,] anyMatrix)
{
    for (int i = 0; i < anyMatrix.GetLength(0); i++)
    {
        for (int j = i + 1; j < anyMatrix.GetLength(1); j++) // j = i+1 чтобы поменять 3 элемента (i=0, j=1, 2; i=1, j=2)
        {
            int temp = anyMatrix[i, j];
            anyMatrix[i, j] = anyMatrix[j, i];
            anyMatrix[j, i] = temp;
        }
    }
}

Transpon(matrix);
PrintMatrix(matrix);