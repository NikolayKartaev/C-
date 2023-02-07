Console.Clear();
int[] bushesArray = new int[new Random().Next(3, 1001)];

Console.WriteLine($"Количество кустов на грядке: {bushesArray.Length}");

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1, 1001);
    }
}
void PrintArray(int[] Col)
{
    int count = 0;
    int number = Col.Length;
    Console.Write("Количества ягод на кустах: ");
    while (count < number)
    {
        Console.Write($"{Col[count]} ");
        count++;
    }
}

FillArray(bushesArray);
PrintArray(bushesArray);

Console.WriteLine();

int Max3ofArray(int[] ArrayDefault)
{
    int i = 0;
    int L = ArrayDefault.Length;
    int MaxPos = 0;
    while (i < L)
    {
        if (i < L - 2)
        {
            if (ArrayDefault[i] + ArrayDefault[i + 1] + ArrayDefault[i + 2] > MaxPos) MaxPos = ArrayDefault[i] + ArrayDefault[i + 1] + ArrayDefault[i + 2];
        }
        if (i == L - 2)
        {
            if (ArrayDefault[i] + ArrayDefault[i + 1] + ArrayDefault[L - i - 2] > MaxPos) MaxPos = ArrayDefault[i] + ArrayDefault[i + 1] + ArrayDefault[L - i - 2];
        }
        if (i == L - 1)
        {
            if (ArrayDefault[i] + ArrayDefault[L - i - 1] + ArrayDefault[L - i] > MaxPos) MaxPos = ArrayDefault[i] + ArrayDefault[L - i - 1] + ArrayDefault[L - i];
        }
        i++;
    }
    return MaxPos;
}
int MaxPosition = Max3ofArray(bushesArray);

Console.WriteLine($"Максимальное количество: {MaxPosition}");



