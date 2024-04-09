using _2;

szamitogep sz1 = new szamitogep();
szamitogep sz2 = new szamitogep(2048,false);

sz1.Kapcsol();

	if (sz1.progmas(400))
{
    Console.WriteLine("400mb masolas sikeres");
}
    else
{
    Console.WriteLine("400mb masolas sikertelen");
}
