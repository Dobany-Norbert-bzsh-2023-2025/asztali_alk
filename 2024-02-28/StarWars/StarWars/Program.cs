using StarWars;

AnakinSkywalker a = new AnakinSkywalker();
Uralkodo u = new Uralkodo();

Console.WriteLine(a);
Console.WriteLine(u);

a.engeddElAHaragod();
u.engeddElAHaragod();

Console.WriteLine();
Console.WriteLine(a);
Console.WriteLine(u);

string s = a.LegyoziE(u) ? "gonoszt legyozi" : "gonoszt nem gyozi";
Console.WriteLine(s);
