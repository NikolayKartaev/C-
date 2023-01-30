// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

int S = new Random().Next(100,1000);
int s1= S/100;
int s3= S%10;
Console.Write("Введено число: ");
Console.WriteLine(S);
Console.Write("Удаляем вторую цифру числа: "); //убираем разряд десятки
Console.WriteLine(s1*10+s3*1); 

int n2= (S/10)%10;
int n3= S%10;
Console.Write("Введено число: ");
Console.WriteLine(S);
Console.Write("Убираем разряд сотни (удаляем первую цифру числа): ");
Console.WriteLine(n2*10+n3*1); //добавил также решение, как убрать разряд сотни

int b1= S/10;
Console.Write("Введено число: ");
Console.WriteLine(S);
Console.Write("Убираем разряд единицы (удаляем третью цифру числа): ");
Console.WriteLine(b1*1); //добавил также решение, как убрать разряд единицы