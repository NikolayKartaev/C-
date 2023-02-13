// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
//Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

void ArrayFill(int[] collection)
{
    for (int index = 0; index < collection.Length; index++)
    {
        collection[index] = new Random().Next(-9, 10);
    }
}

void ArrayFindPlusMinus(int[] collection)
{
    int Positive = 0, Negative = 0, PosC=0, PosN=0;
    foreach (int A in collection)
    {
      if (A>0)
      {
        Positive += A;
        PosC++;
      }
      else
      {
        Negative += A;
        PosN++;
      } 
    }
    Console.WriteLine($"Сумма положительных чисел равна {Positive} ({PosC})");
    Console.WriteLine($"Сумма отрицательных чисел равна {Negative} ({PosN})");
}

int[]array=new int[12];
ArrayFill(array);
Console.WriteLine($"Массив: [{String.Join(", ", array)}]");
Console.WriteLine();

ArrayFindPlusMinus (array);