static int szum(int[] t)
{
    int osszeg = 0;
	for (int i = 0; i < t.Length; i++)
	{
		osszeg += t[i];
	}
	return osszeg;
}


static void rndFeltolt(int[] t)
{
    Random rnd = new Random();
    for (int i = 0; i < t.Length; i++)
    {
        t[i] = rnd.Next(1, 10000);
    }
}

static double atlag(int[] t)
{
		return (double)szum(t) / t.Length;
}

static int paros(int[] t)
{
	int parosI = 0;
	for (int i = 0; i < t.Length; i++)
	{
		if (t[i]%2==0)
		{
			parosI++;
		}
	}
	return parosI;
}

int[] tomb = new int[10];
rndFeltolt(tomb);
Console.WriteLine(string.Join(", ", tomb));
Console.WriteLine("Osszeg: {0}",szum(tomb));
Console.WriteLine("Atlag: {0}",atlag(tomb));
Console.WriteLine("Paros DB: {0}", paros(tomb));

static bool szamjegyekosszege(int szam,int oszto)
{
	string szamStr = szam.ToString();
	int osszeg = 0;
	for (int i = 0; i < szamStr.Length; i++)
	{
		osszeg += (int)szamStr[i];
	}
	if (szam==3||szam==9)
	{
		if (osszeg%oszto==0)
		{
			return true;
		}
		else
		{
			return false;
		}
	}
	else
	{
        if (szam % oszto == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
	
}

Console.Write("Szám: ");
int szam = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\nOszto: ");
int oszto = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(szamjegyekosszege(szam, oszto));

static int szjo(int[] t)
{
	int db = 0;
	for (int i = 0;i < t.Length;i++) 
	{
        string szamStr = t[i].ToString();
        int osszeg = 0;
        for (int j = 0; j < szamStr.Length; j++)
        {
            osszeg += (int)szamStr[j];
        }
		if (osszeg%3==0)
		{
			db++;
		}
    }
	return db;
}

Console.WriteLine("Ennyi 3 oszthato szam van: {0}", szjo(tomb));
