
using System.Net.Http.Headers;

Random  rnd = new Random();
int x = 49;
int y = 10;

static void KiCsi(int x, int y)
{
    string cs = "*";
    Console.SetCursorPosition(x, y);
    Console.WriteLine(cs);
}

Console.SetWindowSize(100, 20);
Console.CursorVisible = false;
Console.ForegroundColor= ConsoleColor.Yellow;

ConsoleKeyInfo key;
do
{
    int a = 0;
    //key = Console.ReadKey();
    switch (rnd.Next(1, 4))
    {
        case 1: x++; break;
        case 2: x--; break;
        case 3: y++; break;
        case 4: y--; break;
    }
    int a = rnd.Next(1, 4);
    /*if (key.Key == ConsoleKey.RightArrow) x++;
    if (key.Key == ConsoleKey.LeftArrow) x--;
    if (key.Key == ConsoleKey.UpArrow) y--;
    if (key.Key == ConsoleKey.DownArrow) y++;*/
    Thread.Sleep(500);
    KiCsi(x, y);




}
while (true);//key.Key != ConsoleKey.Escape);

