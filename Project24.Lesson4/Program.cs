// Factorial
// 5! = 5*4*3*2*1 = 5*4! (5*f(4)) 4! = 4*3! (4*f(3))

int N = int.Parse(Console.ReadLine()!);
double Factorial(int n)
{
    if (n == 1) return n;
    else return n * Factorial(n - 1);
}

for (int i = 1; i <= N; i++)
Console.WriteLine($"{i}! = {Factorial(i)}");