
using ConsoleAppOperatorok;

List<Kifejezesek> kifejezesek = new List<Kifejezesek>();

StreamReader sr = new StreamReader("Kifejezesek.txt");

while (!sr.EndOfStream)
{
    Kifejezesek kifejezes = new Kifejezesek(sr.ReadLine());
    kifejezesek.Add(kifejezes);
}

sr.Close();

// 2.feladat
Console.WriteLine("Kifejezések száma: " + kifejezesek.Count.ToString());

// 3. feladat
Console.WriteLine(kifejezesek.Count(x => x.Szoveg == "mod"));

// 4. feladat
bool van = kifejezesek.Exists(x => x.Szam1 % 10 == 0 && x.Szam2 % 10 == 0);
if (van)
{
    Console.WriteLine("Van ilyen kifejezés!");
}
else
{
    Console.WriteLine("Nincs ilyen kifejezés!");
}

// 5. feladat
var valami = kifejezesek.GroupBy(x => x.Szoveg).ToList();


// 8. feladat

string fileName = "eredmeny.txt";
try
{
    StreamWriter sw = new StreamWriter(fileName);

    foreach (var item in kifejezesek)
    {
        sw.WriteLine($"{item.Szam1} {item.Szoveg} {item.Szam2}");
    }
    Console.WriteLine("Sikeres volt a fájlba írás!");
    sw.Close();
}
catch (Exception hiba)
{
    Console.WriteLine(hiba.Message);
}


