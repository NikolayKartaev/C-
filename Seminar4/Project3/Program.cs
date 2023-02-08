void x10(int[] a) // процедура void
{
a[0] = a[1] * 10;
a[1] = a[2]*5;
}

int[] array = {1, 2, 3, 4, 5};
x10(array);
Console.WriteLine($"[{string.Join(", ", array)}]");