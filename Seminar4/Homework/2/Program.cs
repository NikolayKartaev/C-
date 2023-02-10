// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
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