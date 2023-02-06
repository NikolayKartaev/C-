Console.Clear();
Console.Write("Введите номер четверти: ");
int ch = Convert.ToInt32(Console.ReadLine());

while (ch < 1 || ch > 4)
{
    Console.Write("Вы ошиблись!\nВведите № четверти от 1 до 4: ");
    ch = Convert.ToInt32(Console.ReadLine());
}

if (ch == 1)
{
    Console.WriteLine("x ∈ (0;+U+2208), y ∈ (0;+∞)");
}
else if (ch == 2)
{
    Console.WriteLine("x ∈ (-∞,0), y ∈ (0,+∞)");
}
else if (ch == 3)
{
    Console.WriteLine("x ∈ (-∞,0), y ∈ (-∞,0)");
}
else if (ch == 4)
{
    Console.WriteLine("x ∈ (0,+∞), y ∈ (-∞,0)");
}