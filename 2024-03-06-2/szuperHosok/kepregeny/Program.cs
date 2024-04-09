using System.Runtime.CompilerServices;
using szuperHosok;

class Program
{

    List<ISzuperhos> hosok = new List<ISzuperhos>();

    static void szuperhosok(List<ISzuperhos> hosok)
    {
        foreach (var hos in hosok)
        {
            Console.WriteLine(hos);
        }
    }
    static void szereplok(string fajl)
    {
        var sorok = File.ReadAllLines(fajl);
        foreach (var sor in sorok)
        {
            var hos = sor.Split(" ");
            if (hos[0] == "Vasember")
            {
                var szereplo = new Vasember();
            }
            else
            {
                var szereplo = new Batman();
            }
        }

    }

    

    static void Main(string[] args)
    {
        Console.WriteLine();
    }
        

}