int Sum(int N)
{
    if (N / 10 == 0) // или так: if (n < 10 || n % 10 == n)
        return N;
    else return Sum(N / 10) + N % 10;
}

int N = int.Parse(Console.ReadLine()!);
Console.WriteLine(Sum(N));