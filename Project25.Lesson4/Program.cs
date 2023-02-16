// Последовательность Фибоначчи f(n) = f(n-1) + f(n-2)

double F(int n)
{
    if (n == 1 || n == 2) return 1;
    else return F(n - 1) + F(n - 2);
}

int N = int.Parse(Console.ReadLine()!);
for (int i = 1; i <= N; i++)
{
    Console.WriteLine($"F({i}) = {F(i)}");
}

// int N = Convert.ToInt32(Console.ReadLine()), a0 = 0, a1 = 1, x;
// for (int i = 0; i < N; i++)
// {
//   Console.Write($"{a0} ");
//   x = a0 + a1;
//   a0 = a1;
//   a1 = x;
// }