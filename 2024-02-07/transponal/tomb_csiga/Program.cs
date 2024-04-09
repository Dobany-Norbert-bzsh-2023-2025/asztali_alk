static int[] vector(int[,] tomb)
{
	int a = 0;
    int[] vector = new int[tomb.GetLength(0) * tomb.GetLength(1)];
	for (int i = 0; i < tomb.GetLength(0); i++)
	{
		for (int j = 0; j < tomb.GetLength(1); j++)
		{
			vector[a] = tomb[i,j];
			a++;
		}
	}
	return vector;
}

static void transPon(int[,] matrix)
{
	int[,] trans = new int[matrix.GetLength(1),matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
			trans[j, i] = matrix[i,j];
        }
    }

    for (int i = 0; i < trans.GetLength(0); i++)
    {
        for (int j = 0; j < trans.GetLength(1); j++)
        {
            Console.Write(trans[i,j]);
        }
        Console.WriteLine();
    }
}



int[,] matrix = new int[3, 3]
{
	{1,2,3 },
	{1,3,4},
	{1,4,5},
};
int[] tomb = vector(matrix);

for (int i = 0; i < tomb.Length; i++)
{
    Console.Write(tomb[i] + " ");
}
Console.WriteLine();

transPon(matrix);