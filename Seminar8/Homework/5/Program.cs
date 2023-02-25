// Задача 61: Вывести первые N строк треугольника Паскаля.
// Сделать вывод в виде равнобедренного треугольника

int FindK(int N)
{
    if (N == 1) return 1;
    else return FindK(N - 1) + 2;
}

void FillMatrix(int[,] mtrx)
{
    for (int n = 0; n < mtrx.GetLength(0); n++)
    {
        mtrx[n, mtrx.GetLength(1) / 2 - n] = 1;
        mtrx[n, mtrx.GetLength(1) / 2 + n] = 1;
        int k = mtrx.GetLength(1) / 2 - (n - 2);
        while (n >= 2 && k <= mtrx.GetLength(1) / 2 + (n - 2) && k < mtrx.GetLength(1))
        {
            mtrx[n, k] = mtrx[n - 1, k - 1] + mtrx[n - 1, k + 1];
            k = k + 2;
        }

    }
}

void Print(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            string text = Convert.ToString(matrix[i, j]);
            if (text == "0") text = "";
            Console.Write($"{text}\t");

        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите число строк треугольника Паскаля: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine();

int[,] pascalTrianle = new int[N, FindK(N)];

FillMatrix(pascalTrianle);

Print(pascalTrianle);
Console.WriteLine();

