Console.Clear();

void FillArray (int [] Collection)
{
    int index = 0;
    int length = Collection.Length;
    while (index < length)
    {
        Collection[index]=new Random().Next(1,99);
        index++; //index=index+1
    }
}
void PrintArray (int [] Col)
{
    int count = 0;
    int number = Col.Length;
    Console.Write("Массив: ");
    while (count<number)
    {
        Console.Write($"{Col[count]} ");
        count++;
    }
}
int Max (int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2>result) result=arg2;
    if (arg3>result) result=arg3;
    return result;
}
int MaxArray (int[] ArrayDefault)
{
    int i = 0;
    int L=ArrayDefault.Length;
    int MaxPos =ArrayDefault[i];
    while (i<L)
    {
        if (ArrayDefault[i]>MaxPos) MaxPos=ArrayDefault[i];
        i++;
    }
    return MaxPos;
}
void ChangeOnMinus (int [] array2)
{
    int m =0;
    while (m<array2.Length)
    {
        array2[m]=array2[m]*(-1);
        m++;
    }
}

int[] array = new int [9]; // создать новый массив с 10 элементами

FillArray (array);
PrintArray (array);
Console.WriteLine();

int max1 = Max(
    Max(array[0],array[1],array[2]),
    Max(array[3],array[4],array[5]),
    Max(array[6],array[7],array[8]));
Console.WriteLine($"Максимальное число массива (перебор): {max1}");

int MMA = MaxArray (array);
Console.WriteLine($"Максимальное число массива (метод): {MMA}");

Console.WriteLine();
ChangeOnMinus(array);
int max2 = Max(
    Max(array[0],array[1],array[2]),
    Max(array[3],array[4],array[5]),
    Max(array[6],array[7],array[8]));
PrintArray (array);
Console.WriteLine();

Console.WriteLine($"Максимальное число измененного массива (перебор): {max2}");
MMA = MaxArray (array);
Console.WriteLine($"Максимальное число измененного массива (метод): {MMA}");
