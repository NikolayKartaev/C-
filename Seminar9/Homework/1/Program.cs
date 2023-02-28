int FindSum(int a, int b)
{
    return b == a ? a : b + FindSum(a, b - 1); 

    /*if (b == a) return a;
    return b + FindSum(a, b - 1);*/
}

int FindSumTwo(int a, int b)
{
    return a == b ? b : a + FindSumTwo(a + 1, b);

    /*if (a == b) return b;
    return a + FindSumTwo (a + 1, b);*/
}

Console.Write("Введите значение M: ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение N: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма натуральных элементов в промежутке между {M} и {N} равна {FindSum(M, N)}");
Console.Write($"Сумма натуральных элементов в промежутке между {M} и {N} равна {FindSumTwo(M, N)}");