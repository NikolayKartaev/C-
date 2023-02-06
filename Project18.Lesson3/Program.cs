string Method4(int count, string msg)
{
    string res = String.Empty;
    for (int i = 0; i < count; i++) // цикл for вместо while
    {
        res = res + msg;
    }
    return res;
}
string result = Method4(msg: "-Текст Метода 4- ", count: 4);
Console.WriteLine(result);