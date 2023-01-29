Console.Write("Введите 1-ое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int m = Convert.ToInt32(Console.ReadLine());
// Пользователь вводит 2 числа, необходимо найти максимум
// n > m
// n < m
// n == m
// = - оператор присвоения
// == - проверка на равенство
if (n > m)
    Console.WriteLine($"Max is {n}");
else if (n < m)
    Console.WriteLine($"Max is {m}");
else
    Console.WriteLine($"The number {n} is equal to the number {m}");

    // Console.WriteLine($"Результат {a} + {b} = {a + b}") - интерполяция