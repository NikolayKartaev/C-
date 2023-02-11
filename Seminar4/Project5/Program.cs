Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 0;
while (N>0)
{
    N=N/10;
    count++;
}
Console.WriteLine(count);

//Console.Write($"{Console.ReadLine().Length}");