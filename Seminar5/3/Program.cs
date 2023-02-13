// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

void ArrayFill(int[] collection)
{
    for (int index = 0; index < collection.Length; index++)
    {
        collection[index] = new Random().Next(-9, 10);
    }
}

string FindNumber (int[] collection, int number)
{
  foreach (int element in collection)
  {
    if (element == number) return ($"Number {number} is FOUND");
  }
  return "not found";
}

Console.Clear();
Console.Write("Введите кол-во элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[] array = new int[n];
ArrayFill(array);
Console.WriteLine($"Массив: [{string.Join(", ", array)}]");
Console.WriteLine();

Console.Write("Введите число, которое Вы хотите найти: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();


Console.WriteLine(FindNumber(array, N));
Console.WriteLine();
