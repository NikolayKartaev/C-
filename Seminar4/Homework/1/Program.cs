// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Нельзя использовать Math.Pow();
// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.WriteLine("Введите число A (основу)");
int A = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите число B (степень)");
int B = Convert.ToInt32 (Console.ReadLine());
int result = 1;
for (int i=0; i<B;i++)
{
    result = result*A;
}
Console.Write($"Результат возведения числа {A} в степень {B} равен {result}");