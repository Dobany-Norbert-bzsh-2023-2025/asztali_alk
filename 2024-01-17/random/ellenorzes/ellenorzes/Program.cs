static void Kiiras(int[,] Tomb)
{
    Console.WriteLine();
    for (int i = 0; i < Tomb.GetLength(0); i++)
    {
        for (int j = 0; j < Tomb.GetLength(1);)
        {
            Console.WriteLine(Tomb[i, j]+", ");
        }
        Console.WriteLine();
    }
}

static void Feltolt(int[,] tomb)
{
    Random random = new Random();
    {
        for (int i = 0; i < tomb.GetLength(0); i++)
        {
            for (int j = 0; j < tomb.GetLength(1); j++)
                tomb[i, j] = random.Next(100, 200);
        }
    }    
}

int[,] dimTomb = new int[3, 4]
{
    {12, -4, 5, 2 },
    {7, 2, 0, 22 },
    {8, -3, 2, 7 }
};

Console.WriteLine("[1,1]: " + dimTomb[1,1]);

Console.WriteLine("Hossz: "+dimTomb.GetLength(1));

Kiiras(dimTomb);

int[,] tomb = new int[5, 5];
Feltolt(tomb);
Console.WriteLine("5x5-ös tömb:");
Kiiras(tomb);