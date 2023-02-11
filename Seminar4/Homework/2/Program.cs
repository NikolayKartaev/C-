// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
string? number = Console.ReadLine();
int sum = 0;
if (number is not null)
{
    for (int i = 0; i < number.Length; i++)
    {
        sum = sum + Convert.ToInt32(number[i].ToString());
    }
}
Console.WriteLine($"Сумма цифр числа {number} равно {sum}");


int Num = Convert.ToInt32(number);
int NumberSum(int N)
{
    int res = 0;
    while (N>0)
    {
        res=res + N%10;
        N=N/10;
    }
    return res;
}
int result = NumberSum(Num);
Console.WriteLine($"Сумма цифр числа {number} равно {result}");


