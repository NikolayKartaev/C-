Console.Clear();

int N = new Random().Next(1, 10);
int[] array = new int[N];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-100, 101);
}
Console.WriteLine($"Последовательность до сдвига: {String.Join(" ", array)}");

int K = new Random().Next(-100000, 100001);
int sdv = K % array.Length;

Console.WriteLine($"Число K, на которое нужно сдвинуть: {K}");
Console.WriteLine($"Количество чисел последовательности: {array.Length}");

if (sdv < 0) Console.WriteLine($"Фактически сдвинуть влево на: {sdv}");
if (sdv > 0) Console.WriteLine($"Фактически сдвинуть вправо на: {sdv}");

int[] array2 = new int[N];

for (int index = 0; index < array.Length; index++)
{
    if (sdv > 0)
    {
        if (index + sdv < array.Length)
        {
            array2[index + sdv] = array[index];
        }
        if (index + sdv >= array.Length)
        {
            array2[sdv - (array.Length - index)] = array[index];
        }
    }
    else if (sdv < 0)
    {
        if (index + sdv < 0)
        {
            array2[array.Length + sdv + index] = array[index];
        }
        if (index + sdv >= 0 && index + sdv < array.Length)
        {
            array2[index + sdv] = array[index];
        }
    }
    else array2[index] = array[index];
}

Console.WriteLine($"Последовательность после сдвига: {String.Join(" ", array2)}");