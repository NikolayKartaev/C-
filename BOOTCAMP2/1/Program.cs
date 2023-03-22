Console.Clear();

Console.Write("Введите количество элементов массива: ");
int[] array = new int[int.Parse(Console.ReadLine())];
for (int i = 0; i < array.Length; i++)
{
    array[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("[" + string.Join(", ", array) + "]");

Console.WriteLine(array[3]);
// Сложность алгоритма О(1)

// [5, 3, 4, 1, 2]
// Сложность алгоритма найти сумму данного массива циклом - O(n)

// [1, 2, 3, 4, 5] - Сложность алгоритма быстрой сортировки - O(n * log n)
// ((1 + 5)/2) * 5 = 15 - Сложность алгоритма найти сумму чисел арифметической прогрессии - O(1)

// O(n * log n) + O(1) или O(n * log n + 1)

// Если n - большой, то n < n * log n + 1