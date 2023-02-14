// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();

Console.Write("Введите числа: ");
int[] collection = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
Console.WriteLine();

int count = 0;
for (int i = 0; i < collection.Length; i++) if (collection[i] > 0) count++;

Console.WriteLine($"Вы ввели числа: {string.Join(", ", collection)}\nКоличество введеных чисел больше 0: {count}");


// Console.Write("Введите количество элементов массива ENTER: ");
// int N = int.Parse(Console.ReadLine()!), count=0;
// int[] array = new int[N];

// for (int i = 0; i < N; i++)
// {
//     Console.Write("Введите число и нажмите ENTER: ");
//     array[i] = int.Parse(Console.ReadLine()!);
//     if (array[i] > 0) count++;
// }
// Console.WriteLine($"Вы ввели числа: [{string.Join(", ", array)}]\nКоличество введеных чисел больше 0: {count}");
