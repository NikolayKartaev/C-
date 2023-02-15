// Площадь треугольника
// (Время: 1 сек. Память: 16 Мб Сложность: 15%)
// По целочисленным координатам вершин треугольника (x1,y1), (x2,y2) и (x3,y3) требуется вычислить его площадь.

// Входные данные
// Входной файл INPUT.TXT содержит 6 целых чисел x1,y1,x2,y2,x3,y3 – координаты вершин треугольника. Все числа не превышают 106 по абсолютной величине.

// Выходные данные
// В выходной файл OUTPUT.TXT выведите точное значение площади заданного треугольника.

Console.WriteLine("Введите координаты вершин треугольника через пробел в формате: x1 y1 x2 y2 x3 y3");
int[] array = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();

double a = Math.Sqrt(Math.Pow(array[2] - array[0], 2) + Math.Pow(array[3] - array[1], 2));
double b = Math.Sqrt(Math.Pow(array[4] - array[2], 2) + Math.Pow(array[5] - array[3], 2));
double c = Math.Sqrt(Math.Pow(array[4] - array[0], 2) + Math.Pow(array[5] - array[1], 2));
double p = (a + b + c) / 2;
double S = Math.Round (Math.Sqrt(p * (p - a) * (p - b) * (p - c)),2);

Console.WriteLine(S);