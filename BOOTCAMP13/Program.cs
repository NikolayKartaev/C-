// void CountingSort(int[] inputArray)
// {
//     int[] countArray = new int[10];
//     for (int i = 0; i < inputArray.Length; i++)
//     {
//         countArray[inputArray[i]]++;
//     }

//     int index = 0;
//     for (int i = 0; i < countArray.Length; i++)
//     {
//         for (int j = 0; j < countArray[i]; j++)
//         {
//             inputArray[index] = i;
//             index++;
//         }
//     }
// }

// int[] testArray = { 7, 2, 3, 2, 1, 5, 9, 1, 1 };
// CountingSort(testArray);
// Console.WriteLine(String.Join(", ", testArray));


void CountingSortExtended(int[] inputArray)
{
    int max = inputArray.Max();
    int offset = -(inputArray.Min());

    int[] countArray = new int[max + offset + 1];
    for (int i = 0; i < inputArray.Length; i++)
    {
        countArray[inputArray[i]+offset]++;
    }

    int index = 0;
    for (int i = 0; i < countArray.Length; i++)
    {
        for (int j = 0; j < countArray[i]; j++)
        {
            inputArray[index] = i-offset;
            index++;
        }
    }
}

int[] testArray = { -100000, 100, 5, 1000, 400, 500,-99, 300000 };
CountingSortExtended(testArray);
Console.WriteLine(String.Join(", ", testArray));