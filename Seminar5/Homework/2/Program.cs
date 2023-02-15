/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0 */

Console.Clear();

Console.Write("Введите количество элементов массива: ");
int N = int.Parse(Console.ReadLine()!), sum = 0;
Console.WriteLine();
int[] array = new int[N];


for (int index = 0; index < N; index++)
{
    array[index] = new Random().Next(100, 1000);
    if (index % 2 != 0) sum += array[index];
}
Console.WriteLine($"Массив: [{string.Join(",", array)}]\n Сумма чисел на нечетных позициях: {sum}");


