using System;

class Program
{
    static int cursorLeft = 0;
    static int cursorTop = 0;

    static void Main()
    {
        Console.CursorVisible = false;

        while (true)
        {
            Console.Clear();
            Console.SetCursorPosition(cursorLeft, cursorTop);
            Console.Write("*");

            ConsoleKeyInfo keyInfo = Console.ReadKey(true);

            
            switch (keyInfo.Key)
            {
                case ConsoleKey.UpArrow:
                    cursorTop = Math.Max(0, cursorTop - 1);
                    break;

                case ConsoleKey.DownArrow:
                    cursorTop = Math.Min(Console.WindowHeight - 1, cursorTop + 1);
                    break;

                case ConsoleKey.LeftArrow:
                    cursorLeft = Math.Max(0, cursorLeft - 1);
                    break;

                case ConsoleKey.RightArrow:
                    cursorLeft = Math.Min(Console.WindowWidth - 1, cursorLeft + 1);
                    break;

                case ConsoleKey.Escape:
                    return;
            }
        }
    }
}

