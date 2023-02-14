// Задача 38: Задайте массив вещественных(дробных) чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3.1, 7.23, 22.57, 2.45, 78.78] -> 76.33

Console.Clear();
Console.Write("Введите количество элементов массива: ");
int N = int.Parse(Console.ReadLine()!);

double[] array = new double[N];
int index = 0, start = 1, end = 51;
for (index = 0; index < array.Length; index++)
    array[index] = Math.Round(new Random().NextDouble() * (end - start) + start, 2);

double min = array[0], max = array[0];
for (index = 0; index < array.Length; index++)
{
    if (array[index] < min) min = array[index];
    else if (array[index] > max) max = array[index];
}

Console.WriteLine($"Разница между максимальным и минимальным элементом массива [{string.Join(", ", array)}]:\n{max} - {min} = {max - min}");
Console.WriteLine();


