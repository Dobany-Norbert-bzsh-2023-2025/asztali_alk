using hegyek;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static List<hegy> list = new List<hegy>();
    static void Main(string[] args)
    {
        var sorok = File.ReadAllLines("C:/Users/Diak/dev/dnaa/asztali_alk/2024-03-06-2/hegyek/hegyek/hegyekMo.txt").Skip(1);
        foreach (var line in sorok)
        {
            list.Add(new hegy(line));
        }

        Console.WriteLine($"Hegycsucs db: {list.Count()}");

        int sum = 0;
        foreach (var line in list)
        {
            sum += line.magassag;
        }
        Console.WriteLine($"Magassag szum: {sum}");

        Console.WriteLine($"Magassag szum:{list.Sum(x => x.magassag)}");

        Console.WriteLine($"Atlag mag.: {list.Average(x=>x.magassag)}");

        Console.WriteLine($"900m-nel magasabb: {list.Where(x=>x.magassag>900).Count()}");

        Console.WriteLine($"Max mag.: {list.Max(x=>x.magassag)}");

        Console.WriteLine(list.Count(x=>x.magassag>914.4));
    }

}

