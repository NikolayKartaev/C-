Console.Clear();
int A = new Random().Next(4, 999);
bool IfSimple(int number)
{
    for (int i = 2; i <= Math.Sqrt(number); i++)
    {
        if (number % i == 0) 
        {
            return false;
        }
    }
    return true;
}

bool a = IfSimple(A);

if (a == true) Console.Write($"Число {A} является ПРОСТЫМ");
if (a == false) Console.WriteLine($"Число {A} является составным");
Console.WriteLine();

bool C = false;
int[] array = new int[167];
int j = 0;
int index = 0;
while (index < 167)
{
    while (j < 998)
    {
        if (IfSimple(j) == false) j++;
        else if (IfSimple(j) == true)
        {
            array[index] = j;
        }
        index++;
    }

}
Console.WriteLine($"Простые числа множества: {String.Join(",", array)}");
