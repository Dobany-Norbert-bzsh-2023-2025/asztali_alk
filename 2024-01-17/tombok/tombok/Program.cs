int[] tomb = new int[] { 1, 2, 3, 4, 5,6,7 };
Console.WriteLine(tomb.ToString());
Console.WriteLine(tomb.Length);

static void kitomb(int[] t)
{
	for (int i = 0; i < t.Length; i++)
	{
        Console.Write(t[i]+", ");
       
    }
    Console.WriteLine();
    Console.WriteLine(string.Join(":",t));
}
kitomb(tomb);
Console.WriteLine();

//-------------------------------------------------------------------

int[] tomb2 = new int[7];
for (int i = 0; i < tomb2.Length;i++)
{
    tomb2[i] = tomb[i];
}

Array.Fill(tomb2, 100);
kitomb(tomb2);
Console.WriteLine();

//-------------------------------------------------------------------

Random rnd = new Random();

int[] tomb3 = new int[7];
for (int i = 0; i < tomb3.Length; i++)
{
    tomb3[i] = rnd.Next(1, 100);
}

kitomb(tomb3);
Array.Sort(tomb3);
kitomb(tomb3);
Array.Reverse(tomb3);
kitomb(tomb3);
Console.WriteLine();

//-------------------------------------------------------------------

static void proba(int i, int[] t)
{
    i = 10;
    t[0] = 10;
}
int szam = 5;  
int[] szamTomb = new int[] { 89, 100, 32 };
