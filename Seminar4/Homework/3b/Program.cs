Console.Clear();

int N = new Random().Next(1, 101);
int[] Sherenga = new int[N];
Console.WriteLine($"Количество учеников в классе: {N}");
Console.WriteLine();

for (int i = 0; i < Sherenga.Length; i++)
{
    Sherenga[i] = new Random().Next(150, 201);
}
Console.WriteLine($"Рост учеников в классе: {String.Join(", ", Sherenga)}");
Console.WriteLine();

int PeteHeigth = new Random().Next(150, 201);
Console.WriteLine($"Рост Пети: {PeteHeigth}");
Console.WriteLine();

int kol = 0;
for (int s=0; s<Sherenga.Length;s++)
{
    if(Sherenga[s]>=PeteHeigth) kol=kol+1;
}
Console.WriteLine($"Позиция Пети в шеренге: {kol + 1}");