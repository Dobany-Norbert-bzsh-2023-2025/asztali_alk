static void Ki(int[,] tomb)
{
    for (int i = 0; i < tomb.GetLength(0); i++)
    {
        for (int j = 0; j < tomb.GetLength(1); j++)
        {
            string jel = "";
            if (tomb[i, j] == 0) jel = ((char)186).ToString();
            else jel = ((char)215).ToString();
            Console.Write(jel);
        }
    }
}

//Console.SetWindowSize(30, 30);
//Console.SetBufferSize(30, 30);
int[,] palya = new int[,] {
    { 0,1,1,1,0,0,0,0,0,0 },
    { 0,0,0,1,0,0,0,0,0,0 },
    { 0,0,0,1,0,0,0,0,0,0 },
    { 0,0,0,0,0,0,0,0,0,0 },
    { 0,0,0,0,0,0,0,0,0,0 },
    { 0,1,1,1,1,0,0,0,0,0 },
    { 0,0,0,0,0,0,0,0,0,0 },
    { 0,0,0,0,0,0,0,0,0,0 },
    { 0,0,0,0,0,0,0,0,0,0 },
    { 0,0,0,0,0,0,0,0,0,0 }
};

int[,] tomb = new int[,] {
    { 0,1,1,1,0,0,0,0,0,0 },
    { 0,0,0,1,0,0,0,0,0,0 },
    { 0,0,0,1,0,0,0,0,0,0 },
    { 0,0,0,0,0,0,0,0,0,0 },
    { 0,0,0,0,0,0,0,0,0,0 },
    { 0,1,1,1,1,0,0,0,0,0 },
    { 0,0,0,0,0,0,0,0,0,0 },
    { 0,0,0,0,0,0,0,0,0,0 },
    { 0,0,0,0,0,0,0,0,0,0 },
    { 0,0,0,0,0,0,0,0,0,0 }
};
Ki(tomb);

ConsoleKeyInfo cki;
int beker = 1;
int oszlop, sor;
do
{
    cki = Console.ReadKey();
    if (beker == 1) { oszlop = (int)cki.KeyChar; beker++; }
    if (beker == 2)
    {
        sor = Convert.ToInt32(cki.KeyChar.ToString());
        beker = 1;
        Console.WriteLine(oszlop + "; " + sor);
        if (palya[sor, oszlop] == 1) tomb[sor, oszlop] = 1;
        else tomb[sor, oszlop] = -1;
    }

} while (cki.Key!= ConsoleKey.Escape);