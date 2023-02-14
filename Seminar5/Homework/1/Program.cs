/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2*/

Console.Clear();

Console.Write("Введите количество элементов массива: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine();
int[] array = new int[N];

int ArrayCount(int[] collection)
{
    int n = 0;
    for (int index = 0; index < N; index++)
    {
        collection[index] = new Random().Next(100, 1000);
        if (collection[index] % 2 == 0) n++;
    }
    return n;
}

int count = ArrayCount(array);

Console.WriteLine($"Массив: [{string.Join(",", array)}]\nКоличество четных чисел: {count}");
Console.WriteLine();