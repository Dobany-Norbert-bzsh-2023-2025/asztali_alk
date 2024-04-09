const int MaxSor = 21;
const int MaxOSz = 100;
Console.CursorVisible = false;
static void Palya()
{
    Console.SetCursorPosition(0, (MaxSor/ 2) - 1);
    for (int i = 0; i < MaxOSz; i++)
	{
        Console.Write("-");
    }
    Console.SetCursorPosition(0, (MaxSor/ 2) + 1);
    for (int i = 0; i < MaxOSz; i++)
    {
        Console.Write("-");

    }
    Console.SetCursorPosition(0, (MaxSor / 2) - 3);
    for (int i = 0; i < MaxOSz; i++)
    {
        Console.Write("-");
    }
    Console.SetCursorPosition(0, (MaxSor / 2) + 3);
    for (int i = 0; i < MaxOSz; i++)
    {
        Console.Write("-");

    }
}

static void auto()
{
    int x = 0;
    Random rnd = new Random();
    Console.SetCursorPosition(x, (MaxSor / 2));
    Console.Write(" |I-o-I>");
    Console.SetCursorPosition(x, (MaxSor / 2) + 2);
    Console.Write(" |I-o-I>");
    Console.SetCursorPosition(x, (MaxSor / 2) - 2);
    Console.Write(" |I-o-I>");
    
    do
    {
        Console.SetCursorPosition(x, (MaxSor / 2));
        Console.Write("        ");
        Console.Write(" |I-o-I>");
        x += rnd.Next(0, 4);
        Thread.Sleep(50);
        Console.SetCursorPosition(x, (MaxSor / 2)+2);
        Console.Write("       ");
        Console.Write(" |I-o-I>");
        x += rnd.Next(0, 4);
        Thread.Sleep(50);
        Console.SetCursorPosition(x, (MaxSor / 2) - 2);
        Console.Write("       ");
        Console.Write(" |I-o-I>");
        x += rnd.Next(0, 4);
        Thread.Sleep(50);
    }
    while (x <= 90);
}

Console.SetWindowSize(100, 21);
Console.SetBufferSize(100, 21);
Palya();
auto();



Console.ReadKey();