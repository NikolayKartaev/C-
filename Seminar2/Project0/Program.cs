int number = new Random().Next (10,100);
Console.WriteLine(number);
int n1 = number/10;
int n2 = number%10;
if (n1>n2) Console.Write($"Первая цифра {n1} числа {number} больше второй цифры {n2}");
else if (n1<n2) Console.Write($"Вторая цифра {n2} числа {number} больше первой цифры {n1}");
else Console.Write($"Первая и вторая цифра числа {number} равны");