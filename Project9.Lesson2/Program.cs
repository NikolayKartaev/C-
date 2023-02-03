int FindMax (int a, int b, int c)
{
    int Max=a;
    if (b>Max) Max=b;
    if (c>Max) Max=c;
    return Max;
}
int a1=1;
int a2=2;
int a3=300;

int b1=10;
int b2=200;
int b3=30;

int c1=500;
int c2=150;
int c3=100;

int max1= FindMax (a1,a2,a3);
Console.WriteLine($"Максимум из чисел {a1}, {a2}, {a3} = {max1}");
int max2= FindMax (b1,b2,b3);
Console.WriteLine($"Максимум из чисел {b1}, {b2}, {b3} = {max2}");
int max3= FindMax (c1,c2,c3);
Console.WriteLine($"Максимум из чисел {c1}, {c2}, {c3} = {max3}");
int maxAll= FindMax (max1,max2,max3);
Console.Write($"Максимум из максимумов = {maxAll}");