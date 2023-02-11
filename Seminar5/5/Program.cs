// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

void FillArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1, 11); // [1, 10]
}

void ArrayAction5(int[] array, int[] result)
{
  for (int i = 0; i < result.Length; i++)
    result[i] = array[i] * array[array.Length - 1 - i];
}

Console.Clear();
Console.WriteLine();

Console.Write("Введите кол-во элементов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] array = new int[n];
int[] result = new int[n / 2 + n % 2];

FillArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
ArrayAction5(array, result);
Console.WriteLine($"Конечный массив: [{string.Join(", ", result)}]");