/*
Cортировка пузырьком
Начальный массив: [3, 1, 5, 0, 7, 9, 8]
*/

Console.WriteLine("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] collection = new int[n];
for (int i = 0; i < n; i++)
{
    Console.Write("Введите значения массива: ");
    collection[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Начальный массив: [" + string.Join(", ", collection) + "]");
Console.WriteLine();

for (int current = 0; current < collection.Length - 1; current++)
{
    for (int i = 0; i < collection.Length - 1; i++)
    {
        if (collection[i] > collection[i + 1])
        {
            int temp = collection[i];
            collection[i] = collection[i + 1];
            collection[i + 1] = temp;
        }
    }
    Console.WriteLine(current + "[" + string.Join(", ", collection) + "]");
}