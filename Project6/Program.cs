// Пишем шестую программу на C#: "Сравниваем числа"
int a = 1;
int b = 5;
int c = 10;
int d = 9;
int e = 2;

int max = a;

if (a>max) max = a;
if (b>max) max = b;
if (c>max) max = c;
if (d>max) max = d;
if (e>max) max = e;
Console.Write("max = ");
Console.WriteLine(max);