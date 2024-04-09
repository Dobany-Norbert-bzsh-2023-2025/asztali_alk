static bool Tartalmaz(int szam, int[] tomb)
{
    bool vissza = false;
    for (int i = 0; i < tomb.Length; i++)
        if (tomb[i] == szam) { vissza = true; break; }
    return vissza;
}

int[] tomb = new int[50];
Random random = new Random();
for (int i = 0; i < 50; i++) tomb[i] = random.Next(0,201);

Console.WriteLine(String.Join(", ", tomb));

for (int i = 0; i < 50; i++)
    if (Tartalmaz((2 * tomb[i]), tomb)) Console.Write(tomb[i]+";");