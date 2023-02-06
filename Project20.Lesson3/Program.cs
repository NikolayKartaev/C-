string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде, "
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

string ChangeSymbol(string msg, char oldValue, char NewValue)
{
    string result = String.Empty;
    int stringlength = msg.Length;
    for (int i = 0; i < stringlength; i++)
    {
        if (msg[i] == oldValue) result = result + $"{NewValue}";
        else result = result + $"{msg[i]}";
    }
    return result;
}

string NewText = ChangeSymbol(text, ' ', '|');
Console.WriteLine(NewText);
Console.WriteLine();
NewText = ChangeSymbol(NewText, 'е', 'Е');
Console.WriteLine(NewText);
Console.WriteLine();
NewText = ChangeSymbol(NewText, 'а', 'А');
Console.WriteLine(NewText);

