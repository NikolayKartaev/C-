// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


void SetMatrix(int[,] mtrx)
{
    int n = 1, i = 0, j = 0;
    while (n <= mtrx.GetLength(0) * mtrx.GetLength(1) && i == 0 && j < mtrx.GetLength(1))
    {
        mtrx[i, j] = n;
        j++; n++;
        if (j == mtrx.GetLength(1) - 1 && i == 0)
        {
            while (i < mtrx.GetLength(0) && j == mtrx.GetLength(1) - 1)
            {
                mtrx[i, j] = n;
                i++; n++;
                if (i == mtrx.GetLength(0) - 1 && j == mtrx.GetLength(1) - 1)
                {
                    while (i == mtrx.GetLength(0) - 1 && j >= 0)
                    {
                        mtrx[i, j] = n;
                        j--; n++;
                    }
                }
            }
        }
    }
    n=10; j = 0; i = mtrx.GetLength(0) - 1;
    if (j == 0 && i == mtrx.GetLength(0) - 1)
    {
        while (i > 0 && j == 0)
        {
            mtrx[i, j] = n;
            n++; i--;
            if (j == 0 && i == 1)
            {
                while (i == 1 && j < mtrx.GetLength(1) - 1)
                {
                    mtrx[i, j] = n;
                    n++; j++;
                    if (j == mtrx.GetLength(1) - 1 - 1 && i == 1)
                    {
                        while (i < mtrx.GetLength(0) - 1  && j == mtrx.GetLength(1) - 1 -1)
                        {
                            mtrx[i, j] = n;
                            n++; i++;
                            if (i == mtrx.GetLength(0) - 1-1  && j == mtrx.GetLength(1)  -1)
                            {
                                while (i < mtrx.GetLength(0) - 1  && j == mtrx.GetLength(1) - 1 -1);
                            }

                        }
                    }
                }
            }
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

Console.Write("Введите равное количество строк и стобцов квадратной матрицы: ");
int size = int.Parse(Console.ReadLine()!);
int[,] matrix = new int[size, size];

SetMatrix(matrix);

PrintMatrix(matrix);