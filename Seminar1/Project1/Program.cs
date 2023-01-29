Console.Clear();
Console.WriteLine("Введите первое число ");
int a =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int b =int.Parse(Console.ReadLine()!);
int max =0;
if (a>b)
{
    max=a;
}
else
{
    max=b;
}
Console.Write($"Максимальное число = {max}");

// Console.WriteLine($"Результат {a} + {b} = {a + b}") - интерполяция