using ButorModels;
using ButorModels2;

Butorlap b1 = new Butorlap(350,270, Type.Tartolap);

Console.WriteLine(b1);

Butor butor = new Butor();
Random rnd = new Random();
for (int i = 0;i<13;i++)
{
    butor.lapHozzaad(new Butorlap(rnd.Next(200, 400), rnd.Next(100, 500)), (rnd.Next(1, 3) == 1 ? Type.Tartolap : Butorlap.type.Hatlap));
}




Console.WriteLine(butor);
