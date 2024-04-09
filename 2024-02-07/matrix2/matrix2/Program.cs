

static void feltolt(int[,] tomb)
{
    Random rnd = new Random(); 
    for (int i = 0; i < tomb.GetLength(0); i++)
    {
        for (int j = 0; j < tomb.GetLength(1); j++)
        {
            tomb[i, j] = rnd.Next(100);
        }
    }
}
static void kiir(int[,] tomb)
{
    for (int i = 0; i < tomb.GetLength(0); i++)
    {
        for (int j = 0; j < tomb.GetLength(1); j++)
        {
            Console.Write(tomb[i, j] + " ");
        }
        Console.WriteLine();
    }
}

static void kiirAtlo(int[,] tomb)
{

    for (int i = 0; i < tomb.GetLength(0); i++)
    {
        if (i==0)
        {
            Console.Write(tomb[i, i] + " ");
            Console.Write("       ");
            Console.Write(tomb[i, tomb.GetLength(0) - 1 - i] + " ");
        }
        if (i == 1)
        {
            Console.Write("   ");
            Console.Write(tomb[i, i] + " ");
            Console.Write(tomb[i, tomb.GetLength(0) - 1 - i] + " ");
            Console.Write("   ");
        }
        if (i == 2)
        {
            Console.Write("   ");
            Console.Write(tomb[i, tomb.GetLength(0) - 1 - i] + " ");
            Console.Write(tomb[i, i] + " ");
            
            Console.Write("   ");
        }
        if (i == 3)
        {
            Console.Write(tomb[i, tomb.GetLength(0) - 1 - i] + " ");
            Console.Write("       ");
            
            Console.Write(tomb[i, i] + " ");
        }
        Console.WriteLine();

    }
    
    
}

int[,] tomb = new int[4, 4];
feltolt(tomb);
kiir(tomb);
Console.WriteLine();
kiirAtlo(tomb);
