// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"


string OutputNumbers(int m, int n)
{
    if (n == m)
        return $"{m}";
    return OutputNumbers(m, n - 1) + $", {n}";
}

string OutputNumbersTwo(int m, int n)
{
    if (m == n)
        return $"{n}";
    return $"{m}, " + OutputNumbersTwo(m + 1, n);
}

Console.Clear();
Console.Write("Введите 1 число: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите 2 число: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(OutputNumbers(m, n));
Console.WriteLine(OutputNumbersTwo(m, n));