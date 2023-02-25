// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

string OutputNumbers(int n)
{
    if (n == 1)
        return "1";
    return OutputNumbers(n - 1) + $", {n}";
}


Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(OutputNumbers(n));




string OutputNumbers(int n)
{
    if (n == 1)
        return "1";
    return  $"{n}, " + OutputNumbers(n - 1);
}

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(OutputNumbers(n));



