int[] numbers = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
Console.WriteLine($"[{string.Join(", ", numbers)}]");