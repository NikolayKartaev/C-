// Задача 61: Вывести первые N строк треугольника Паскаля.
// Сделать вывод в виде равнобедренного треугольника

int FindK(int N)
{
    if (N == 1) return 1;
    else return FindK(N - 1) + 2;
}



Console.Write("Введите число строк треугольника Паскаля: ");
int N = int.Parse(Console.ReadLine()!);

void FillMatrix(int[,] mtrx)
{
    int k = mtrx.GetLength(1) / 2;
    for (int n = 0; n < mtrx.GetLength(0); n++)
    {

        while (k < FindK(N))
        {
            mtrx[n, mtrx.GetLength(1) / 2 - n] = 1;
            mtrx[n, mtrx.GetLength(1) / 2 + n] = 1;

            int q = 1;
            while (q <= n && k + 1 < mtrx.GetLength(1) && n - 1 >= 0 && k - 1 >= 0)
            {
                mtrx[n, k] = mtrx[n - 1, k - 1] + mtrx[n - 1, k + 1];
                mtrx[n, k - q] = mtrx[n - 1, k - q - 1] + mtrx[n - 1, k];
                mtrx[n, k + q] = mtrx[n - 1, k] + mtrx[n - 1, k + q + 1];
                q++;
            }
            k++;
        }

    }
}

int[,] pascalTrianle = new int[N, FindK(N)];

FillMatrix(pascalTrianle);


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

Print(pascalTrianle);
