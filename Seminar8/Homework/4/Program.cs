// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

bool CheckNumber(int[] array, int number)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number) // если такое число уже есть в массиве, вовзращаем 0
            return false;
    }
    return true; //возвращаем 1, если числа нет в массиве
}


void ThreeDArrayInput(int[,,] threeDArray)
{
    for (int k = 0; k < threeDArray.GetLength(0); k++)
    {
        for (int i = 0; i < threeDArray.GetLength(1); i++)
        {
            for (int j = 0; j < threeDArray.GetLength(2); j++)
            {



                    Console.Write($"{threeDArray[i, j, k]}({i}, {j}, {k})\t");
            }
            Console.WriteLine();
        }
    }
}

Console.Clear();
Console.Write("Введите размер трехмерного массива через пробел: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();

while (size[0]*size[1]*size[2] > end - start)
        Console.Write("Массив такого размера");
int[,,] threeDimensionArray = new int[size[0], size[1], size[2]];

ThreeDArrayInput(threeDimensionArray);