// Пишем третью программу на C#: "Сложение двух чисел"
Console.Write("Введите 1-ое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int result = numberA+numberB;

Console.Write($"Сумма чисел {numberA} и {numberB} равна {numberA+numberB}");
