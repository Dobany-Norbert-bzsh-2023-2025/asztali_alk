using haziallatok.Data;
using haziallatok.Models;
using Microsoft.EntityFrameworkCore;

PetContext context = new PetContext();



if (!context.Pets.Any())
{
    var sorok = File.ReadAllLines(@"C:\Users\Diak\dev\dnaa\asztali_alk\2024-03-13\HaziAllatok.csv").Skip(1);
    foreach (var s in sorok)
    {
        context.Pets.Add(new Pet(s));
    }

    context.SaveChanges();
}
if (!context.Owners.Any())
{
    var sorok = File.ReadAllLines(@"C:\Users\Diak\dev\dnaa\asztali_alk\2024-03-13\Gazda.csv").Skip(1);
    foreach (var s in sorok)
    {
        context.Owners.Add(new Owner(s));
    }

    context.SaveChanges();
}

/*foreach (var s in context.Pets.Where(x=>x.Faj.Equals("Teknős")))
{
    Console.WriteLine(s);
}

Console.WriteLine($"Teknősök száma: {context.Pets.Where(x=>x.Faj.Equals("Nyúl")).Count()}");*/

foreach (var owner in context.Owners.Include(x=>x.Pet))
{
    Console.WriteLine(owner);
}