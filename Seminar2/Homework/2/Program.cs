// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.Clear();
Console.Write("Введите число: ");
int number = Convert.ToInt32 (Console.ReadLine());

if (number<100 & number>-100) Console.Write ("Третьей цифры нет");
else if (number<1000 & number>-1000)
{
    int N=number%10;
    if (N<0) N=N*(-1);
    Console.Write ($"Третья цифра числа {number} - {N}");
}
else if (number<10000 & number>-10000)
{
    int N=(number/10)%10;
    if (N<0) N=N*(-1);
    Console.Write ($"Третья цифра числа {number} - {N}");
}
else if (number<100000 & number>-100000)
{
    int N=(number/100)%10;
    if (N<0) N=N*(-1);
    Console.Write ($"Третья цифра числа {number} - {N}");
}
else if (number<1000000 & number>-1000000)
{
    int N=(number/1000)%10;
    if (N<0) N=N*(-1);
    Console.Write ($"Третья цифра числа {number} - {N}");
}
else if (number<10000000 & number>-10000000)
{
    int N=(number/10000)%10;
    if (N<0) N=N*(-1);
    Console.Write ($"Третья цифра числа {number} - {N}");
}
else if (number<100000000 & number>-100000000)
{
    int N=(number/100000)%10;
    if (N<0) N=N*(-1);
    Console.Write ($"Третья цифра числа {number} - {N}");
}
else if (number<1000000000 & number>-1000000000)
{
    int N=(number/1000000)%10;
    if (N<0) N=N*(-1);
    Console.Write ($"Третья цифра числа {number} - {N}");
}
else 
{
    int N=(number/10000000)%10;
    if (N<0) N=N*(-1);
    Console.Write ($"Третья цифра числа {number} - {N}");
}