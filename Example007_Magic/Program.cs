Console.Clear();

int xa = 30, ya = 10, xb = 40, yb = 1, xc = 50, yc = 10;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.Write("+");

Console.SetCursorPosition(xc, yc);
Console.Write("+");

int x = xa, y = xb;

int count = 0;

while (count < 100)
{
    int what = new Random().Next(0, 3); // [0;3) 0 1 2
    if (what == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }

    if (what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }

    if (what == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }

Console.SetCursorPosition(x, y); 
Console.Write("+");
count = count + 1; 

}