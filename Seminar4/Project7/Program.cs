void ArrayFill(int [] collection)
{
    for (int index = 0; index < collection.Length; index++)
    {
        collection [index] = new Random().Next(0,2);
    }
}

int[]array= new int[8];
ArrayFill(array);
Console.WriteLine($"Массив: [{String.Join(",",array)}]");