// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.Clear();
Console.Write("Введите число: ");
int number = Convert.ToInt32 (Console.ReadLine());

if (number<100 & number>-100) Console.Write ("Третьей цифры нет");
else 
{
while (number>1000 ||number<-1000) number=number/10;
int N=number%10;
if (N<0) N=N*(-1);
Console.Write(N);
}