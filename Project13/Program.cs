Console.Clear();

void FillArray(int[] col)
{
    int i=0;
    int Length = col.Length;
    while (i<Length)
    {
        col[i]=new Random().Next(20,36);
        i++;
    }
}

void PrintArray(int[] collectionPr)
{  
    int PrLength = collectionPr.Length;
    int PrIndex = 0;
    Console.Write("Массив: ");

    while (PrIndex < PrLength)
    {
        Console.Write($"{collectionPr[PrIndex]} ");
        PrIndex++;
    }
    
    // for (int PrIndex = 0; Console.WriteLine(collectionPr[PrIndex]); PrIndex++);
}

int[] array= new int [21];

FillArray(array);
PrintArray(array);

Console.WriteLine();

int FindMax (int[] collectionFM)
{
    int index = 0;
    int N=collectionFM.Length;
    int max = collectionFM[index];

    while (index<N)
    {
        if (collectionFM[index]>max)
        {
            max=collectionFM[index];
        }
        index++;
    }
    return max;
}
int IndexOfNumber (int[] collection2, int FIND)
{
    int numberCol2 =collection2.Length;
    int col2Index = 0;
    int IndexNumber = -1;
    while (col2Index<numberCol2)
    {
        if (collection2[col2Index] == FIND)
        {
            IndexNumber=col2Index;
        }
        col2Index++;
    }
    return IndexNumber;
}
int MAXIMUM = FindMax(array);
Console.WriteLine($"Максимум: {MAXIMUM}");

int Positin = IndexOfNumber(array, 33);
Console. WriteLine(Positin);
