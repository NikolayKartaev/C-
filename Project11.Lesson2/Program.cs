int[]array={14,22,3,43,50,36,57,50};
int n = array.Length;

int find = 50;
int index=0;

while (index<n)
{
    if (array[index]==find)
    {
        Console.WriteLine(index);
        break;
    }
    index=index+1;
}
