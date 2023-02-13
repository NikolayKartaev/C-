Console.Clear();
int[] a = {1, 2, 3, 4, 5};
int[] b = new int[a.Length];
for (int i = 0; i < b.Length; i++)
  b[i] = a[i];
b[0] = b[0] + 5;

Console.WriteLine(string.Join(" ", a));
Console.WriteLine(string.Join(" ", b));