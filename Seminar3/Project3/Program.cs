Console.Write("Введите координату X точки A: ");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y точки A: ");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату X точки B: ");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y точки B: ");
double y2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Расстояние равно: ");

double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
Console.WriteLine(Math.Round(result, 2));