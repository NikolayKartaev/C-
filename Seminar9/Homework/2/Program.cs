double AckermannFunction(double m, double n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return AckermannFunction(m - 1, 1);
    return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
}

Console.Write("Введите аргумент m функции: ");
double m = Convert.ToDouble(Console.ReadLine());

while (m < 0)
{
    Console.Write("Вы ошиблись.\nВведите неотрицательное значение аргумента m: ");
    m = Convert.ToDouble(Console.ReadLine());
}

Console.Write("Введите аргумент n функции: ");
double n = Convert.ToDouble(Console.ReadLine());

while (n < 0)
{
    Console.Write("Вы ошиблись.\nВведите неотрицательное значение аргумента n: ");
    n = Convert.ToDouble(Console.ReadLine());
}

Console.WriteLine();
Console.Write($"Результат вычисления функции Аккермана равен: {AckermannFunction(m,n)}");
