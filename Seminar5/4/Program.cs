// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-100, 101); // [-9, 9]
}

int ReleaseArray(int[] array)
{
    int count = 0;
    foreach (int element in array)
    {
        if (element >= 10 && element <= 99) count++;
    }
    return count;
}

    Console.Clear();

    int[] array2 = new int[10];
    FillArray(array2);
    
    Console.WriteLine($"Начальный массив: [{string.Join(", ", array2)}]");
    Console.WriteLine();

    int A = ReleaseArray(array2);
    Console.WriteLine(A);
