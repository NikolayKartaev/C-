// Factorial
Console.Write("Введите число, факториал которого вы хотите найти: ");
int N=Convert.ToInt32(Console.ReadLine());
int factorial=1;
int n=1;
while (n<=N)
{
    factorial=factorial*n;
    n++;
}
Console.WriteLine($" Факториал числа !{N} = {factorial}");