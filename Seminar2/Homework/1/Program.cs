// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого
//  числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.Clear();
Console.Write("Введите трехзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
while (a<-999 || (a>-100 & a<100) || a>999)
{
    Console.Write("Это не трехзначное число! \nВведите трехзначное число:");
    a = Convert.ToInt32(Console.ReadLine());
    
}

int b = a/10;
int c = b%10;
if (c<0) c=c*(-1);
Console.WriteLine($"Вторая цифра числа {a}: {c} ");