string? stroka = Console.ReadLine();
if (stroka is not null)
{
    Console.WriteLine(Convert.ToInt32(stroka[2].ToString()) * 5);
}

// stroka[2] - обращаемся к символу с индексом 2 строки. 
// ToString() - переводим символ в строку
// Convert.ToInt32 - переводим строку в целое число 