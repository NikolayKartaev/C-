// Сбор черники

// В фермерском хозяйстве в Карелии выращивают чернику. Она растет на круглой грядке, причем кусты высажены только по окружности. // Таким образом, у каждого куста есть ровно два соседних. Всего на грядке растет N кустов. // Эти кусты обладают разной урожайностью, поэтому ко времени сбора на них выросло различное число ягод – на i-ом кусте выросло ai ягод.
// В этом фермерском хозяйстве внедрена система автоматического сбора черники. Эта система состоит из управляющего модуля и 
// нескольких собирающих модулей. Собирающий модуль за один заход, находясь непосредственно перед некоторым кустом, 
// собирает ягоды с этого куста и с двух соседних с ним. // Напишите программу для нахождения максимального числа ягод, которое может собрать за один заход собирающий модуль, 
// находясь перед некоторым кустом заданной во входном файле грядки.
// Входные данные
// Первая строка входного файла INPUT.TXT содержит целое число N (3 ≤ N ≤ 1000) – количество кустов черники. 
// Вторая строка содержит N целых положительных чисел a1, a2, ..., aN – число ягод черники, растущее на соответствующем кусте. Все ai не превосходят 1000.

// Примеры
// №	INPUT.TXT	OUTPUT.TXT
// 4
// 1 2 3 4         	9

// 3
// 1 2 3	        6

Console.Clear();

int bushesNumber = new Random().Next(3, 10);
int[] bushesArray = new int[bushesNumber];

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
    Console.Write("Массив: ");
    while (count < number)
    {
        Console.Write($"{Col[count]} ");
        count++;
    }
}

FillArray(bushesArray);
PrintArray(bushesArray);

Console.WriteLine();
Console.WriteLine($"Количество кустов: {bushesNumber}");

bushesNumber = 0;
int MAX = 0;
Console.WriteLine();

int Max3Array(int[] ArrayDefault)
{
    int i = 0;
    int L = ArrayDefault.Length;
    int MaxPos = ArrayDefault[i] + ArrayDefault[i+1] + ArrayDefault[i+2];
    while (i < L-2)
    {
        if (ArrayDefault[i] + ArrayDefault[i+1] + ArrayDefault[i+2] > MaxPos) MaxPos = ArrayDefault[i] + ArrayDefault[i+1] + ArrayDefault[i+2];
        i++;
    }
    return MaxPos;
}

// while (bushesNumber < bushesArray.Length)
// {
//     if (bushesArray[bushesNumber] + bushesArray[bushesNumber + 1] + bushesArray[bushesNumber + 2] > MAX)
//     {
//         MAX = bushesArray[bushesNumber] + bushesArray[bushesNumber + 1] + bushesArray[bushesNumber + 2];
//     }
//     bushesNumber++;
// }

MAX = Max3Array(bushesArray);
Console.WriteLine(MAX);

