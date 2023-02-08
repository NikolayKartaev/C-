void plus5 (ref int number) // процедура void
{
number = number + 5;
}

int N = 10;
plus5(ref N);
Console.WriteLine(N);