// Seminar 3 Homework.Number 1
// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write ("Введите пятизначное число: ");
string? number = Convert.ToString(Console.ReadLine());
int n = Convert.ToInt32(number)!;

while (number!.Length!=5 || n < 10000)
{
    Console.WriteLine ("Вы ввели не пятизначное число!\nВведите пятизначное число");
    number = Convert.ToString(Console.ReadLine());
    n = Convert.ToInt32(number);
}
if (number[0]==number[4] && number[1]==number[3]) Console.WriteLine($"Число {number} ЯВЛЯЕТСЯ палиндромом.");
else Console.WriteLine($"Число {number} НЕ является палиндромом.");