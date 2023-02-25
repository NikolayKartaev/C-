// Необходимо сложить 2 числа с помощью рекурсии

int sum(int a, int b)
{
    if (b == 0)
        return a;
    return sum(a + 1, b - 1);
}

Console.Clear();
Console.Write("Введите 1-ое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Результат: {a} + {b} = {sum(a, b)}");