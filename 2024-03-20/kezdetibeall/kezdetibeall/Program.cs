using ClassLibrary.Data;
using ClassLibrary.Modells;
using System;

namespace Kezdetibeall
{
    public class Program
    {
        static void KiIr(IEnumerable<object> adatok)
        {
            foreach(var item in adatok)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            CegContext db = new CegContext();
            if (!db.Alkalmazott.Any())
            {
                var sorok = File.ReadAllLines(@"C:\\Users\\Diak\\Downloads\\alkalmazott.csv").Skip(1);
                foreach(var line in sorok)
                {
                    db.Alkalmazott.Add(new Alkalmazott(line));

                }
                db.SaveChanges();
            }

            KiIr(db.Alkalmazott);
            KiIr(db.Alkalmazott.Select(y => y.Nev));
            KiIr(db.Alkalmazott.Select(y => new { y.Nev, y.Fizetes }));
            KiIr(db.Alkalmazott.Select(y => new { y.Nev, EvesJovedelem = y.Fizetes * 12 }).OrderByDescending(x=>x.EvesJovedelem).Skip(1).Take(2));
            KiIr(db.Alkalmazott.Select(x => new {x.OsztalyId,x.Beosztas,x.FonokId}));
            KiIr(db.Alkalmazott.Select(y => new { y.Nev, y.Beosztas, y.Belepes }).OrderBy(x => x.Belepes));
            KiIr(db.Alkalmazott.Where(x => x.Nev.Equals("Skót")));
            KiIr(db.Alkalmazott.Where(x => x.Fizetes < 1200).OrderBy(x=>x.Fizetes).Select(x=>x.Nev));
            KiIr(db.Alkalmazott.Where(x => x.Fizetes < 2000 && x.Fizetes > 1000));
            Console.WriteLine($"Közepesen keresők száma: {(db.Alkalmazott.Where(x => x.Fizetes < 2000 && x.Fizetes > 1000).Count())}");

            int[] t = { 7982, 7566, 7788, 7902};
            KiIr(db.Alkalmazott.Where(x => t.Contains(x.FonokId)));



        }
    }
    
}
