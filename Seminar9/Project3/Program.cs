int Sum(int N)
{
    if (N % 10 == N) // или так: if (N < 10), или так: (N / 10 == 0)
        return N;
    else return Sum(N / 10) + N % 10;
}

int N = int.Parse(Console.ReadLine()!);
Console.WriteLine(Sum(N));