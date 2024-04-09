static void ki(int[] tomb)
{
    Console.WriteLine(String.Join(", ",tomb));
}
int[] szamok = new int[] { 2, 4, 5, 6, 7, 8 };
int[,] matrix = new int[5, 5];
int[][] tombInTomb = new int[3][];
tombInTomb[0] = new int[6];
tombInTomb[1] = new int[3];
tombInTomb[2] = new int[1];

Random rnd = new Random();

for (int i = 0; i < tombInTomb.Length; i++)
{
	for (int j = 0; j < tombInTomb[i].Length; j++)
	{
		tombInTomb[i][j] = rnd.Next(0, 30);
        Console.Write(tombInTomb[i][j] + ":");
    }
    Console.WriteLine();
}

ki(szamok);