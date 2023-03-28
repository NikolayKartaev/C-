public static class Sorting
{
    public static int[] QuickSorting(int[] array, int left, int right)
    {
        int i = left, j = right;
        int pivot = array[Random.Shared.Next(left, right)];
        while (i <= j)
        {
            while (array[i] < pivot) i++;
            while (array[j] > pivot) j--;

            if (i <= j)
            {
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
                i++;
                j--;
            }


        }
        if (i < right) QuickSorting(array, i, right);
        if (j > left) QuickSorting(array, left, j);
        return array;
    }
    public static int[] QuickSorting2(int[] array, int left, int right)
    {
        int i = left, j = right;
        int pivot = array[Random.Shared.Next(left, right)];
        while (i <= j)
        {
            while (array[i] < pivot) i++;
            while (array[j] > pivot) j--;


            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
            i++;
            j--;



        }
        if (i < right) QuickSorting(array, i, right);
        if (j > left) QuickSorting(array, left, j);
        return array;
    }
}