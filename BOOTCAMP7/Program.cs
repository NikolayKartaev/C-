using static Sorting;
using static Infrastructure;


Console.Clear();

int arraySize = 100;
int[] arr = arraySize.CreateArray()
.Show();

QuickSorting(arr, 0, arraySize-1);
Console.WriteLine();

arr.Show();

int[] arr2=arr;
QuickSorting(arr2, 0, arraySize-1);
Console.WriteLine();

arr2.Show();

