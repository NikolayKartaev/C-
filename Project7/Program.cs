// Пишем седьмую программу на C#: "Рисуем треугольник Серпинского"
Console.Clear();
//Console.SetCursorPosition(10,4);
//Console.WriteLine("@");

int xa = 60, ya = 1,
    xb = 1, yb = 35,
    xc = 120, yc =35;

Console.SetCursorPosition(xa,ya);
Console.WriteLine("*");

Console.SetCursorPosition(xb,yb);
Console.WriteLine("*");

Console.SetCursorPosition(xc,yc);
Console.WriteLine("*");

int x=xa, y=xb;
int count = 0;

while (count<9990)
{
    int random = new Random().Next(0,3);
    if (random == 0)
    {
        x = (x+xa)/2;
        y = (y+ya)/2;   
    } 
    if (random == 1)
    {
        x = (x+xb)/2;
        y = (y+yb)/2;  
    }
    if (random == 2)
    {
        x = (x+xc)/2;
        y = (y+yc)/2;  
    }
    Console.SetCursorPosition(x,y);
    Console.WriteLine("-");
    count+=1;
}