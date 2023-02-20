// Создаем функцию, показывающую уникальность элемента в массиве. Если элемент уже есть в массиве, возвращаем значение false

bool CheckNumber(int[] array, int number)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number) // если такое число уже есть в массиве, вовзращаем 0
            return false;
    }
    return true; //возвращаем 1, если числа нет в массиве
}

int CheckMatrix(int[,] mtrx, int[] arr)
{
    int k = 0;
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            mtrx[i, j] = new Random().Next(1, 16); // наполняем матрицу случайными числами
            Console.Write($"{mtrx[i, j]}\t"); // выводим матрицу в консоль
            if (CheckNumber(arr, mtrx[i, j])) // если в массиве есть элемент из матрицы, условие не срабатывает (false)
            {
                arr[k] = mtrx[i,j]; // если в массиве еще нет элемента из матрицы, то условие сработает, в позицию массива
                // с индексом k запишется значение из матрицы с соответствующими индексами
                k++; // подсчитывает количество уникальных элементов
            }
        }
        Console.WriteLine();
    }
    return k; // возвращает количество уникальных элементов
}

void CountTimesElement (int [,] mtrx, int [] arr, int countArray)
{
    for (int n = 0; n < countArray; n++)
    {
        int count = 0;
        for (int i = 0; i < mtrx.GetLength(0); i++)
        {
            for (int j = 0; j < mtrx.GetLength(1); j++)
            {
                if (arr [n] == mtrx[i,j]) count++;
            }
        }
        Console.WriteLine ($"Элемент {arr[n]} встречается {count} раз");
    }
}

Console.Write("Введите количество строк и столбцов матрицы: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
Console.WriteLine();

int[,] matrix = new int[size[0], size[1]];
int[] array = new int[size[0] * size[1]];

int countArray = CheckMatrix (matrix, array);
Console.WriteLine();

Console.WriteLine ($"{string.Join(", ", array)}");
Console.WriteLine();

CountTimesElement (matrix, array, countArray);