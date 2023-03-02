int Sum(int n)
{
    if (n / 10 == 0) // или так: if (n < 10 || n % 10 == n)
        return n;
    return Sum(n / 10) + n % 10;

    /*return n / 10 == 0 ? n : Sum(n / 10) + n % 10*/
}

int N = int.Parse(Console.ReadLine()!);
Console.WriteLine(Sum(N));