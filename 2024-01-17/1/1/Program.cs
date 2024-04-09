/*using System;

namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("asd");
        }
    }
}

var - auto valtozo
ctrl + d - sor masolas





*/



Console.Write("Nev?");
var nev = Console.ReadLine();

Console.Write("Kor?");
int kor = Convert.ToInt32(Console.ReadLine());

Console.Write("Suly (2 tizedes pontossaggal)?");
double suly = Convert.ToDouble(Console.ReadLine());
string sulycsop = "";
if (suly<=69)
{
    sulycsop = "Konnyu kateg"; 
}
else
{
    sulycsop = "Nehez kateg";
}

Console.WriteLine("Név: " + nev + 
                  "\nKor: " + kor.ToString() + 
                  "\nSúly: " + Math.Round(suly,2).ToString() + " kg - "+sulycsop );

Console.Write("Hanyadik nap? (1-7)");
int napSzam = Convert.ToInt32(Console.ReadLine());
string nap;

switch (napSzam)
{
    case 1:case 2:case 3:nap = "Messze még a hévége";break;
    case 4: case 5: nap = "Itt a hétvége"; break;
    case 6: case 7: nap = "Hétvége van";break;
    default: nap = "Probléma napokkal!";break;
}
Console.WriteLine(nap);
Console.WriteLine("Nyomj valamit a kilépéshez");
Console.ReadKey();
