// Factorial
int number = 8;
int factorial=1;
int next = 1;
while (next<=number)
{
    factorial=factorial*next;
    next++;
}
Console.WriteLine(factorial);