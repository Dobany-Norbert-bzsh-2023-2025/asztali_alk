using _3;
Hallgato h1 = new Hallgato("1");
Hallgato h2 = new Hallgato("2",1,0);

h2.targyFelvesz(5);

h1.vizsgazik();
h2.vizsgazik();
h2.targyFelvesz(5);
h2.vizsgazik();
h2.targyFelvesz(5);
h2.vizsgazik();


Console.WriteLine(h1);
Console.WriteLine(h2);