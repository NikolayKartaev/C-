// Транспонирование - 4
// (Время: 1 сек. Память: 16 Мб Сложность: 15%)
// Задана целочисленная матрица, состоящая из N строк и M столбцов.
//Требуется транспонировать ее относительно горизонтали.

// Входные данные
// Первая строка входного файла INPUT.TXT содержит два натуральных числа N и M – количество строк и столбцов матрицы.
//В каждой из последующих N строк записаны M целых чисел – элементы матрицы. 
//Все числа во входных данных не превышают 100 по абсолютной величине.

// Выходные данные
// В выходной файл OUTPUT.TXT выведите матрицу, полученную транспонированием исходной матрицы относительно горизонтали.


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
    for (int i = 0; i < mtrx.GetLength(0) / 2; i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            int temp = mtrx[i, j];
            mtrx[i, j] = mtrx[mtrx.GetLength(0) - i - 1,j];
            mtrx[mtrx.GetLength(0) - i - 1,j] = temp;
        }
    }
}

ChangeMatrix (matrix);
PrintMatrix(matrix);