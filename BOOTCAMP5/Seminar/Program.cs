using System.Diagnostics;

bool Check(int[] array)
{

    for (int i = 0; i < array.Length - 1; i++)
    {
        if (array[i] > array[i + 1]) return false;
    }
    return true;
}


bool show = !true;

int n = 50_000;
int max = 100;

int[] array = new int[n];

for (int i = 0; i < n; i++) array[i] = Random.Shared.Next(max);
// for (int i = 0; i < n; i++) array[i] = n - i;

if (show) Console.WriteLine($"[{String.Join(',', array)}]");

int[] arr0 = new int[n];
int[] arr1 = new int[n];
int[] arr2 = new int[n];
int[] arr3 = new int[n];

Array.Copy(array, arr0, n);
Array.Copy(array, arr1, n);
Array.Copy(array, arr2, n);
Array.Copy(array, arr3, n);

Stopwatch sw = new Stopwatch();
sw.Start();

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n - 1; j++)
    {
        if (arr0[j] > arr0[j + 1])
        {
            int temp = arr0[j];
            arr0[j] = arr0[j + 1];
            arr0[j + 1] = temp;
        }
    }
}

sw.Stop();
System.Console.WriteLine($"arr0 - {Check(arr0)} {sw.ElapsedMilliseconds}ms");


if (show) Console.WriteLine($"arr1: [{String.Join(',', arr1)}]");

sw = new Stopwatch();
sw.Start();

for (int k = 0; k < n - 1; k++)
{
    for (int i = 0; i < n - 1; i++)
    {
        if (arr1[i] > arr1[i + 1])
        {
            int temp = arr1[i];
            arr1[i] = arr1[i + 1];
            arr1[i + 1] = temp;
        }
    }
}
sw.Stop();
System.Console.WriteLine($"arr1 - {Check(arr1)} {sw.ElapsedMilliseconds}ms");

if (show) Console.WriteLine($"arr1: [{String.Join(',', arr1)}]");
if (show) Console.WriteLine($"arr2: [{String.Join(',', arr2)}]");
// Console.ReadLine();

sw = new Stopwatch();
sw.Start();

for (int k = 0; k < n - 1; k++)
{
    for (int i = 0; i < n - 1 - k; i++)
    {
        if (arr2[i] > arr2[i + 1])
        {
            int temp = arr2[i];
            arr2[i] = arr2[i + 1];
            arr2[i + 1] = temp;
        }
    }
}

sw.Stop();
System.Console.WriteLine($"arr2 - {Check(arr2)} {sw.ElapsedMilliseconds}ms");


if (show) Console.WriteLine($"arr3: [{String.Join(',', arr3)}]");

sw = new Stopwatch();
sw.Start();

for (int k = 0; k < n; k++)
{
    bool check = true;
    for (int i = 0; i < n - 1 - k; i++)
    {
        if (arr3[i] > arr3[i + 1])
        {
            check = false;
            int temp = arr3[i];
            arr3[i] = arr3[i + 1];
            arr3[i + 1] = temp;
        }
    }
    if (check) break;
}

sw.Stop();
System.Console.WriteLine($"arr3 - {Check(arr3)} {sw.ElapsedMilliseconds}ms");


if (show) Console.WriteLine($"arr2: [{String.Join(',', arr2)}]");