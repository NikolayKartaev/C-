// Seminar 3 Homework.Number 4 (дополнительная задача)

Console.Clear();
int[] bushesArray = new int[new Random().Next(3, 1001)];

// int[] bushesArray = { 101, 110, 3, 4, 5, 2, 4, 1, 1, 100, 34, 100}; - проверка работоспособности

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

int i = 0;
int L = bushesArray.Length;
int MaxPos = 0;
int a = 0; int b = 0; int c = 0;

while (i < L)
{
    if ((i < L - 2) && (bushesArray[i] + bushesArray[i + 1] + bushesArray[i + 2] > MaxPos)) 
    {
        MaxPos = bushesArray[i] + bushesArray[i + 1] + bushesArray[i + 2];
        a = i; b = i + 1; c = i + 2;
    }
    else if ((i == L - 2) && (bushesArray[i] + bushesArray[i + 1] + bushesArray[L - i - 2] > MaxPos))
    {
        MaxPos = bushesArray[i] + bushesArray[i + 1] + bushesArray[L - i - 2];
        a = i; b = i + 1; c = L - i - 2;
    }
    else if ((i == L - 1) && (bushesArray[i] + bushesArray[L - i - 1] + bushesArray[L - i] > MaxPos))
    {
        MaxPos = bushesArray[i] + bushesArray[L - i - 1] + bushesArray[L - i];
        a = i; b = L - i - 1; c = L - i;
    }
    i++;
}
Console.WriteLine($"Максимальное число ягод, собранное за 1 ход с кустов №{a}, №{b}, №{c}: {MaxPos}");