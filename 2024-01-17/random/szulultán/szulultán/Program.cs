int n = 100;
bool[] cellak = new bool[n];
//for (int i = 0; i < n; i++) Console.Write(cellak[i] + ",");

for (int i = 1; i <= n; i++)
    for (int j = i; j <= n; j = j + i)
    {
        //Console.WriteLine("i:" + i + ", j: " + j);
        cellak[j - 1] = !cellak[j - 1];
    }

Console.WriteLine("Nyitogatás vége:");
for (int i = 0; i < n; i++) if (cellak[i]) Console.Write((i+1) + ",");