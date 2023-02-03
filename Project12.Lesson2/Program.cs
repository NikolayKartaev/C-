void FillArray (int [] Collection)
{
    int index = 0;
    int length = Collection.Length;
    while (index < length)
    {
        Collection[index]=new Random().Next(1,11);
        index++; //index=index+1
    }
}
void PrintArray (int [] Col)
{
    int count = 0;
    int number = Col.Length;
    while (count<number)
    {
        Console.Write($"{Col[count]} ");
        count++;
    }
}

int[] array = new int [10]; // создать новый массив с 10 элементами

FillArray (array);
PrintArray (array);

void ChangeOnMinus (int [] array2)
{
    int m =0;
    while (m<array2.Length)
    {
        array2[m]=array2[m]*(-1);
        m++;
    }
}
Console.WriteLine();
ChangeOnMinus(array);
PrintArray (array);