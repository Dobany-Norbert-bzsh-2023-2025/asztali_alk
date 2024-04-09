using objects;
macska cica1 = new macska("macsak1",3.5,false);
macska cica2 = new macska("macska2", 0.1);



if (cica1.Eszik(0.3))
{
    Console.WriteLine($"{cica1.Nev} evett");
}
else
{
    Console.WriteLine($"{cica1.Nev} nem volt ehes");
}
if (cica2.Eszik(0.1))
{
    Console.WriteLine($"{cica2.Nev} evett");
}
else
{
    Console.WriteLine($"{cica2.Nev} nem volt ehes");
}

cica1.Futkos();
cica2.Futkos();

Console.WriteLine(cica1);
Console.WriteLine(cica2);