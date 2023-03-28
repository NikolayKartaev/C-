public static class Sorting
{
    public static int[] SelectionSort(this int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            int minPos = i;
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] < array[minPos]) minPos = j;
            }
            int temp = array[minPos];
            array[minPos] = array[i];
            array[i] = temp;
        }
        return array;
    }
}