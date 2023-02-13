void ArrayFill(int[] collection)
{
    for (int index = 0; index < collection.Length; index++)
    {
        collection[index] = new Random().Next(0, 11);
    }
}

void Reverse(int[] collection)
{
    for (int index = 0; index < collection.Length / 2; index++)
    {
        int temp = collection[index];
        collection[index] = collection[collection.Length - index - 1];
        collection[collection.Length - index - 1] = temp;
    }
}

Console.Clear();
Console.WriteLine();
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
ArrayFill(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.WriteLine();
Reverse(array);

Console.WriteLine($"Конечный массив: [{string.Join(", ", array)}]");
Console.WriteLine();