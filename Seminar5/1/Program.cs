// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
//Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

void FillArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(-9, 10); // [-9, 9]
}

void ArrayFindPlusMinus(int[] array)
{
  int Positive = 0, Negative = 0;
  foreach (int i in array)
  {
    if (i > 0)
      Positive += i; // Positive = summaPositive + i;
    else
      Negative += i;
  }
  Console.WriteLine($"Сумма положительных чисел равна {Positive}");
  Console.WriteLine($"Сумма отрицательных чисел равна {Negative}");
}

Console.Clear();
int[] array = new int[12];
FillArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
ArrayFindPlusMinus(array);