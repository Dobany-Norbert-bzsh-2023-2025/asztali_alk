using System;

Random rnd = new Random();
string[] jelszo = new string[15];
for (int i = 0; i<15;i++)
{
    int a = rnd.Next(0, 2);
    if (a == 0)
    {
        jelszo[i]= Convert.ToString(rnd.Next(0, 10));
    }
    else
    {
        int num = rnd.Next(0, 26 );
        char let = (char)('a' + num);
        int b = rnd.Next(0, 2);
        if (b == 0)
        {
            string letStr = Convert.ToString(let);
            let = Convert.ToChar(letStr.ToUpper());
        }
        jelszo[i] = Convert.ToString(let);
        
    }
}

for (int i = 0; i < jelszo.Length; i++)
{
    Console.Write(jelszo[i]);
}

