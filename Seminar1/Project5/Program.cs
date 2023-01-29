// Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3 b = 9 -> нет

Console.Clear();
Console.Write("Введите 1-ое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a/b==b)
{
    if (b<0)
    {
        Console.WriteLine($" {a} = ({b})*({b}) - первое число является квадратом второго");
    }
    else 
    {
        Console.WriteLine($" {a} = {b}*{b} - первое число является квадратом второго");
    }
}
else
{
    Console.WriteLine(" Первое число не является квадратом второго"); 
}
