using System.Linq;

string text = Console.ReadLine()!
                        .Replace("(", "")
                        .Replace(")", "");

Console.WriteLine();

var data = text.Split(" ") //  string [] data = text.Split(" ");
               .Select(e => e.Split(","))
               .Select(e => (x: int.Parse(e[0]), y: int.Parse(e[1])))
               .Where(e => (e.x % 2 != 0 && e.y < e.x))
               .Select(e => (e.x * 10, e.y + 10))
               .ToArray();
for (int i = 0; i < data.Length; i++) // data - массив массивов (массив из массивов data[i])
{
    Console.WriteLine(data[i]); // Console.WriteLine(data[i].a*2);
}