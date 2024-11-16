#region 1. Feladat
using System.ComponentModel;
using System.Globalization;
using System.Runtime.Serialization.Formatters;

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("1. Feladat");
Console.ResetColor();

// File beolvasás
string file_name = "eso.txt";
string[] sorok = File.ReadAllLines(file_name);
int napokSzama = int.Parse(sorok[0]);
double[] esoMennyiseg = new double[napokSzama];

for (int i = 0; i < napokSzama; i++)
{
    esoMennyiseg[i] = double.Parse(sorok[i + 1]);
}

Console.Write("Beolvasod a fájlt?: ");
Console.ForegroundColor = ConsoleColor.Yellow;
string valasz = Console.ReadLine();
Console.ResetColor();

if (valasz == "igen")
{
    Console.Write("A választott fájl beolvasása sikeres!: ");
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine(file_name);
    Console.ResetColor();
}

else if (valasz == "nem")
{
    Console.WriteLine("A fájlt nem kívántad beolvasni...");
    return;
}

else
{
    Console.WriteLine("Nem értelmezhető!");
}
#endregion

#region pause
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Nyomj entert a továbblépéshez!");
while (Console.ReadKey().Key != ConsoleKey.Enter)
{
}
Console.WriteLine("1 másodperc...");
Thread.Sleep(1000);
Console.ResetColor();
#endregion

#region 2. Feladat
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("2. Feladat");
Console.ResetColor();

static void NapMinosites(string[] sorok)
{
    for (int i = 0; i < sorok.Length; i++)
    {
        double esoMennyiseg = double.Parse(sorok[i]);
        if (esoMennyiseg == 0)
        {
            return "Nem volt eső";
        }

        else if (esoMennyiseg < 10)
        {
            return "Gyenge eső";
        }

        else
        {
            return "Sok eső";
        }
    }
    
}
#endregion

#region pause
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Nyomj entert a továbblépéshez!");
while (Console.ReadKey().Key != ConsoleKey.Enter)
{
}
Console.WriteLine("1 másodperc...");
Thread.Sleep(1000);
Console.ResetColor();
#endregion

#region 3. Feladat
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("3. Feladat");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Yellow;
for (int i = 0; i < napokSzama; i++)
{
    string minosites = NapMinosites(esoMennyiseg[i]);
    Console.WriteLine($"május {i + 1}. {esoMennyiseg[i]:0.0} mm – {minosites}");
}
Console.ResetColor();
#endregion

#region pause
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Nyomj entert a továbblépéshez!");
while (Console.ReadKey().Key != ConsoleKey.Enter)
{
}
Console.WriteLine("1 másodperc...");
Thread.Sleep(1000);
Console.ResetColor();
#endregion

#region 4. Feladat
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("4. Feladat");
Console.ResetColor();

List<int> kevesebbEsotNapiak = new List<int>();
for (int i = 1; i < napokSzama; i++)
{
    if (esoMennyiseg[i] < esoMennyiseg[i - 1])
    {
        kevesebbEsotNapiak.Add(i + 1);
    }
}

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Májusban az előző napinál kevesebb eső esett:");
foreach (var nap in kevesebbEsotNapiak)
{
    Console.WriteLine(nap);
}
Console.ResetColor();

File.WriteAllLines("kevesebb.txt", kevesebbEsotNapiak.Select(x => x.ToString()));
#endregion