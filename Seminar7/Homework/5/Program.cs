void FillMatrix(int[,] anyMatrix, string[,] mtrx)
{
    for (int i = 0; i < anyMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < anyMatrix.GetLength(1); j++)
        {
            anyMatrix[i, j] = new Random().Next(0, 2);
            if (anyMatrix[i, j] == 0) mtrx[i, j] = "B";
            else mtrx[i, j] = "W";
        }
    }
}

void PrintMatrix(string[,] anyMatrix)
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

Console.Write("Введите через пробел количество строк и столбцов матрицы от 1 до 100: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
int[,] matrix2 = new int[size[0], size[1]];

string[,] imageBefore = new string[size[0], size[1]];
string[,] imageAfter = new string[size[0], size[1]];

FillMatrix(matrix, imageBefore);
PrintMatrix(imageBefore);
Console.WriteLine();

FillMatrix(matrix2, imageAfter);
PrintMatrix(imageAfter);
Console.WriteLine();

int CountErrors(string[,] mtrx, string[,] mtrx2)
{
    int counterror = 0;
    for (int i = 0; i < mtrx2.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx2.GetLength(1); j++)
        {
            if (mtrx2[i, j] == mtrx[i, j]) counterror++;
        }
    }
    return counterror;
}

Console.WriteLine (CountErrors(imageBefore, imageAfter));