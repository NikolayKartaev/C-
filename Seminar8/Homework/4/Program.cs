// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

bool CheckNumber(int[,,] mtrx, int number)
{
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            for (int k = 0; k < mtrx.GetLength(2); k++)
            {
                if (mtrx[i, j, k] == number)
                    return false;
            }
        }
    }
    return true;
}

void ThreeDArrayInput(int[,,] threeDArray)
{

    for (int i = 0; i < threeDArray.GetLength(0); i++)
    {
        for (int j = 0; j < threeDArray.GetLength(1); j++)
        {
            for (int k = 0; k < threeDArray.GetLength(2); k++)
            {
                int n = 10;
                int number = new Random().Next(10, 100);
                while (n < 90)
                {
                    if (CheckNumber(threeDArray, number)) threeDArray[i, j, k] = number;
                    else
                    {
                        number = new Random().Next(10, 100);
                    }
                    n++;
                }

                Console.Write($"{threeDArray[i, j, k]}({j}, {k}, {i})\t");
            }
            Console.WriteLine();
        }
    }
}





Console.Clear();
Console.Write("Введите размер трехмерного массива через пробел: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();

while (size[0] * size[1] * size[2] > 90)
{
    Console.Write("Массив такого размера из неповторяющихся двузначных чисел задать невозможно.\nВведите размер трехмерного массива через пробел: ");
    size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
}

int[,,] threeDimensionArray = new int[size[0], size[1], size[2]];

ThreeDArrayInput(threeDimensionArray);