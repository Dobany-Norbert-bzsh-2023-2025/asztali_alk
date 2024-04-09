using System.Buffers;

int[,] buvos = new int[3, 3]
{
    {4,9,2},
    {3,5,7},
    {8,1,6}
    
};

static void buvosE(int[,] tomb)
{
    bool buvos = true;
    int[] sorok = new int[tomb.GetLength(0)];
    int[] atlok = new int[2];
    int osszeg = 0;
    for (int i = 0; i < tomb.GetLength(0); i++)
    {
        for (int j = 0; j < tomb.GetLength(1);j++)
        {
            osszeg += tomb[i,j];
        }
        sorok[i] = osszeg;
        osszeg = 0;
    }
    Console.WriteLine(osszeg);

    osszeg = 0;
    for (int i = 0;i < tomb.GetLength(0);i++)
    {
        osszeg += tomb[i, i];
    }
    atlok[0] = osszeg;
    Console.WriteLine(osszeg);

    osszeg = 0;
    for (int i = 0; i < tomb.GetLength(0); i++)
    {
        osszeg += tomb[i, tomb.GetLength(0) - 1 - i];
    }
    atlok[1] = osszeg;
    Console.WriteLine(osszeg);

    for (int i = 0; i < sorok.Length; i++)
    {
        if (sorok[0] != sorok[i])
        {
            buvos = false;
        }
    }
    
    if (atlok[0] != atlok[1])
    {
        buvos = false;
    }
    if (buvos==false)
    {
        Console.WriteLine("nem");
    }
    else
    {
        Console.WriteLine("igen");
    }

}

buvosE(buvos);
