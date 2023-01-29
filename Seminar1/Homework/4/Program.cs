// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine()), n=2;
if (N%2==0) 
{
    Console.Write($"Четные числа от 1 до {N}: ");
    while (n<=N)
    {
        Console.Write($"{n} ");
        n=n+2;
    }
}  
else
{
    Console.Write($"Четные числа от 1 до {N}: ");
    while (n<N)
    {
        Console.Write($"{n} ");
        n=n+2;
    }
}