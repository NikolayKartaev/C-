// Пишем четвертую программу на C#: "Деление двух чисел"
double numberA = new Random().Next(1,100001);
Console.Write("Первое число: ");
Console.WriteLine(numberA);
double numberB = new Random().Next(1,11);
Console.Write("Второе число: ");
Console.WriteLine(numberB);
Console.Write("Частное двух числе равно: ");
double div = numberA/numberB;
Console.WriteLine(div);