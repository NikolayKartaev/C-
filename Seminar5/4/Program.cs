// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

void ArrayFill(int[] collection)
{
    for (int index = 0; index < collection.Length; index++)
    {
        collection[index] = new Random().Next(0, 1001);
    }
}

int FindNumbers(int[] collection)
{
    int count = 0;
    foreach (int element in collection)
    {
        if (element >= 10 && element <= 99) count++;
    }
    return count;
}

Console.Clear();
int[] array = new int[123];
ArrayFill (array);
Console.WriteLine($"Массив: [{String.Join(" ", array)}]");
Console.WriteLine ();
Console.WriteLine(FindNumbers(array));
Console.WriteLine ();
