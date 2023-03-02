// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

string OutputNumbersUp(int n)
{
    return n == 1 ? "1" : OutputNumbersUp(n - 1) + $", {n}";
    // if (n == 1)
    //     return "1";
    // return OutputNumbersUp(n - 1) + $", {n}";
}

string OutputNumbersDown(int n)
{
    return n == 1 ? "1" : $"{n}, " + OutputNumbersDown(n - 1);
    
    // if (n == 1)
    //     return "1";
    // return $"{n}, " + OutputNumbersDown(n - 1);
}

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(OutputNumbersUp(n));
int m = n;
Console.WriteLine(OutputNumbersDown(m));



