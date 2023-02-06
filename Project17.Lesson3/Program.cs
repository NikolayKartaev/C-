// Метод, тип 4

string Method4(int count, string msg)
{
    int i = 0;
    string res = String.Empty;
    while (i < count)
    {
        res = res + msg;
        i++;
    }
    return res;
}
string result = Method4(msg: "-Текст Метода 4- ", count: 4);
Console.WriteLine(result);