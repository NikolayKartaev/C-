// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

void ArrayFill(int[] collection)
{
    for (int index = 0; index < collection.Length; index++)
    {
        collection[index] = new Random().Next(-9, 10);
    }
}
void ChangeMinus(int[] collection)
{
    for (int index = 0; index < collection.Length; index++)
    {
        collection[index] *= (-1);
    }

}

Console.Clear();

Console.Write("Введите кол-во элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
Console.WriteLine();
ArrayFill (array);
Console.WriteLine($"Исходный массив: [{String.Join(", ", array)}]");
Console.WriteLine();

ChangeMinus (array);
Console.WriteLine($"Итоговый массив: [{String.Join(", ", array)}]");
Console.WriteLine();
