int FindSum(int a, int b)
{
    if (b == a) return b;
    else return b + FindSum(a, b - 1);
}

Console.Write("Введите значение M: ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение N: ");
int N = int.Parse(Console.ReadLine()!);
Console.Write($"Сумма натуральных элементов в промежутке между {M} и {N} равна {FindSum(M, N)}");