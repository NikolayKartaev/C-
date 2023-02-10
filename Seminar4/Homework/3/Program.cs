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

for (int k = 0; k < Sherenga.Length - 1; k++)
{
    int max = k;
    for (int j = k + 1; j < Sherenga.Length; j++)
    {
        if (Sherenga[j] > Sherenga[max]) max = j;
    }
    int temp = Sherenga[k];
    Sherenga[k] = Sherenga[max];
    Sherenga[max] = temp;
}
Console.WriteLine($"Ученики без Пети выстроились в шеренгу по невозрастанию: {String.Join(", ", Sherenga)}");
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
Console.WriteLine();

int[] Sherenga2 = new int[Sherenga.Length + 1];

for (int index = 0; index < Sherenga2.Length; index++)
{
    if (index < kol) Sherenga2[index] = Sherenga[index];
    else if (index == kol) Sherenga2[index] = PeteHeigth;
    else Sherenga2[index] = Sherenga[index - 1];
}
Console.WriteLine($"Ученики вместе с Петей выстроились в шеренгу по невозрастанию: {String.Join(", ", Sherenga2)}");