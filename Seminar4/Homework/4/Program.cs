Console.Clear();

int N = new Random().Next(1, 50);
int[] array = new int[N];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-100, 101);
}
Console.WriteLine($"Массив до сдвига: {String.Join(" ", array)}");

int K = new Random().Next(-100000, 100001);
int sdv = K % array.Length;

if (sdv < 0) Console.WriteLine($" Сдвинуть влево на: {sdv}");
if (sdv > 0) Console.WriteLine($" Сдвинуть вправо на: {sdv}");

Console.WriteLine($"Число K: {K}");
Console.WriteLine($"Количество чисел: {array.Length}");

for (int index = 0; index < array.Length; index++)
{
    if (sdv > 0)
    {
        if (index + sdv < array.Length)
        {
            int temp = array[index + sdv];
            array[index + sdv] = array[index];
            array[array.Length-sdv] = temp;
        }
        if (index + sdv >= array.Length)
        {
            int temp = array[index + sdv - array.Length];
            array[index + sdv - array.Length] = array[index];
            array[index + sdv] = temp;
        }
    }
    else if (sdv < 0)
    {
        if (index - sdv < array.Length)
        {
           int temp = array[index - sdv];
            array[index - sdv] = array[index];
            array[array.Length+sdv] = temp;
        }
        if (index - sdv >= array.Length)
        {
            int temp = array[index - sdv];
            array[index - sdv] = array[index];
            array[index - sdv + array.Length] = temp;
        }
    }
    else array[index] = array[index];
}

Console.WriteLine($"Массив после сдвига: {String.Join(" ", array)}");