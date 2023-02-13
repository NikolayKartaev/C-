// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

void ArrayFill(int[] collection)
{
    for (int index = 0; index < collection.Length; index++)
    {
        collection[index] = new Random().Next(0, 11);
    }
}

void ArrayAction(int[] collection, int[] result)
{
    for (int index = 0; index < result.Length; index++) //result.Length = collection.Length/2
        result[index] = collection[index] * collection[collection.Length - index - 1];
}

Console.Clear();
Console.WriteLine();

Console.Write("Введите кол-во элементов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] array = new int[n];
int[] array2 = new int[n / 2 + n % 2];
Console.WriteLine();
ArrayFill(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.WriteLine();

ArrayAction(array, array2);
Console.WriteLine($"Произведения чисел массива: [{string.Join(", ", array2)}]");
Console.WriteLine();