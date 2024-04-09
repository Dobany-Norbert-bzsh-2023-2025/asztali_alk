using System.Reflection.Metadata;
static void pozki(int x, int y, string szoveg)
{
    Console.SetCursorPosition(x,y);
    Console.Write(szoveg);

}

ConsoleKeyInfo cki;
do
{

    

int tipp = 0;
int i = 0;
Random rnd = new Random();
int szam = rnd.Next(1, 100);
Console.WriteLine(szam);


Console.SetWindowSize(110,25);

Console.Clear();
pozki(46, 0, "Szamkitalalo jatek");



pozki(4, 4, "Mi lehet a szám (1-100)?  Tipp: (10 tipped van)   ");

do
{
    tipp = Convert.ToInt32(Console.ReadLine());
    Console.SetCursorPosition(21, 4);
    if (tipp > szam)
    {
        pozki(4,2,"A tipped túl nagy     ");
    }
    else if (tipp < szam)
    {
        pozki(4, 2, "A tipped túl kicsi");
    }
    i++;
}
while (tipp != szam & i < 10);
if (szam==tipp)
{
    Console.WriteLine("Gratulálok, talált");
}
else
{
    Console.WriteLine("Sajnos nem sikerült");
}
    pozki(43,10,"Játszol még?: I/N");
    Console.CursorVisible = false;
    cki = Console.ReadKey();
    Console.CursorVisible = true;
} while (cki.Key == ConsoleKey.I);
/*i = 0;
while (tipp != szam & i < 10)
{
    tipp = Convert.ToInt32(Console.ReadLine());
    if (tipp > szam)
    {
        Console.WriteLine("A tipp túl nagy");
    }
    else if (tipp < szam)
    {
        Console.WriteLine("A tipped túl kicsi");
    }
    i++;
}
if (i==10)
{
    Console.WriteLine("Sajnos nem sikerült eltalálnod");
}
else
{
    Console.WriteLine("Gratulálok, talált");
}*/

