// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

Console.WriteLine("Введите десятичное число: ");
int D = Convert.ToInt32(Console.ReadLine());
string B = string.Empty;
while (D > 0)
{
    B = Convert.ToString(D % 2) + B;
    D = D/2;
}
Console.WriteLine(B);