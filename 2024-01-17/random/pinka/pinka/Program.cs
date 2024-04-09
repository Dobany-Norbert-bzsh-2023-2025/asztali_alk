using System.Runtime.CompilerServices;
static int HanszorSzerepel(int keresendo, int[] tomb)
{
    int hanyszor = 0;
    for (int i = 0; i < tomb.Length; i++)
    if (tomb[i] != 0; i < tomb.Length; i++)
    {
    if (KiirTomb[i] == keresendo) hanyszor++;    
    }
return hanyszor;
}
static void KiirTomb(int[,] tomb)
{
    for (int i = 0; i < tomb.GetLength(0); i++)
    {
        for (int j = 0; j < tomb.GetLength(1); j++)
            Console.Write(tomb[i, j] + ", ");
        Console.WriteLine();
    }
}
static int[,] Eljaras(int[,] t1, int[,] t2)
{
    Console.WriteLine("A tömb " + t1.GetLength(0) + "x" + t1.GetLength(1) + " méretű");
    
    if ((t1.GetLength(0) != t2.GetLength(0)) ||
        (t1.GetLength(1) != t2.GetLength(1)))
    {
        return new int[,] { { -1 } };
    }
    else
    {
        for (int i = 0; i < t1.GetLength(0); j++)
            for (int j = 0; j < t1.GetLenght(1); j++)
                if (t1[i, j] > t2[i, j]) visszaTomb[i, j] = t1[i, j];
                else visszaTomb[i, j] = t2[i, j];
    }
    
    return null;
}

int[,] szamok1 = new int[,]
{
    {1, 2, 3, 4 },
    {1, 2, 3, 4 },
    {1, 2, 3, 4 }
};
int[,] szamok2 = new int[,]
{
    {11, 0, 16, 1 }

}

Eljaras(szamok1, szamok2);

KiirTomb(Eljaras(szamok1, szamok2));

Console.WriteLine();

Console.WriteLine("10-ben: " + HanyszorSzerepel(11, new int[] { 10, 10, 4, 10, 6, 7, 10 }));

int[] tomb = new int[] { 10, 10, 4, 6, 6, 7, 10 };

for (int i = 0; i < tomb.Length; i++)
{
    Console.WriteLine(tomb[i] + ": " + HanyszorSzerepel(tomb[i] tomb));
}