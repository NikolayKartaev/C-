//Сортировка выбором

int[] array = { 100, 1, 9, 8, 1000, 7, 5, 2014, 1, 9, 1500, 25, 44447, 5582 };

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

void SelectionSortMin(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        int minPos = i;
        for (int j= i+1; j<arr.Length;j++) // поиск минимального элемента и его индекса из отрезка от j (i+1) до конечного (arr.Length)
        {
            if (array[j]<array[minPos]) minPos=j; // 
        }
        int temp = arr[i]; // во временную переменную помещаем значение элемента с индексом i
        arr[i] = arr[minPos]; // на место элемента с индексом i ставим минимальный элемент
        arr[minPos] = temp; // на место найденного минимального элемента ставим элемент с индексом i из неотсортированного множества
    }
}

void SelectionSortMax(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        int maxPos = i;
        for (int j= i+1; j<arr.Length;j++) // поиск максимального элемента и его индекса из отрезка от j (i+1) до конечного (arr.Length)
        {
            if (array[j]>array[maxPos]) maxPos=j; // 
        }
        int temp = arr[i]; // во временную переменную помещаем значение элемента с индексом i
        arr[i] = arr[maxPos]; // на место элемента с индексом i ставим максимальный элемент
        arr[maxPos] = temp; // на место найденного максимального элемента ставим элемент с индексом i из неотсортированного множества
    }
}
PrintArray(array);
Console.WriteLine();
SelectionSortMin (array);
PrintArray(array);
Console.WriteLine();
SelectionSortMax (array);
PrintArray(array);