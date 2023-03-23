int n = int.Parse(Console.ReadLine()!);
int[,] matrix = new int[n, n];
for (int i = 0; i < n; i++)
{
    for (int j = i; j < n; j++)
    {
        matrix[i, j] = (i + 1) * (j + 1);
        matrix[j, i] = (i + 1) * (j + 1);

    }
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write($"{matrix[i, j]}\t");
    }
    Console.WriteLine();
}

// Сложность алгоритма О(n^2 / 2)

// for (int i = 0; i < n; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         Console.Write(i*j);
//         Console.Write(\t);
//     }
//     Console.WriteLine();    
// }

// Сложность алгоритма О(n^2)