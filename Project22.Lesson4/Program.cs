string[,] table = new string[4, 4];

// table[0,0] table[0,1] table[0,2] table[0,3]
// table[1,0] table[1,1] table[1,2] table[1,3]
// table[2,0] table[2,1] table[2,2] table[2,3]
// table[3,0] table[3,1] table[3,2] table[3,3]

table[0, 0] = "[0, 0]";
table[1, 1] = "[1, 1]";
table[2, 2] = "[2, 2]";
table[3, 3] = "[3, 3]";

for (int rows = 0; rows < 4; rows++)
{
    for (int columns = 0; columns < 4; columns++)
    {
        Console.Write($"*{table[rows, columns]}* ");
    }
    Console.WriteLine();
}
Console.WriteLine();




void PrintMatrix(int [,] matr)
{
    for (int rows = 0; rows < matr.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++)
        {
            Console.Write($"{matr[rows, columns]} ");
        }
        Console.WriteLine();
    }
}

int[,] matrix = new int[3, 4];
PrintMatrix(matrix);
Console.WriteLine();


void FillMatrix (int [,] matr)
{
    for (int rows = 0; rows < matr.GetLength(0);rows++)
    {
        for (int columns = 0; columns<matr.GetLength(1); columns++)
        {
            matr[rows,columns] = new Random().Next (1,10);
        }
    }
}
FillMatrix(matrix);
PrintMatrix(matrix);


