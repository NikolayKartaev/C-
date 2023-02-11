Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

int result = 1;
for (int i = 1; i<=N;i++)
{
    result*=i; // result = result*i
}
Console.WriteLine(result);
