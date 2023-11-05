using _20231105Szoftverek;
using System.Security.Cryptography.X509Certificates;
using System.Text;

var sr = new StreamReader(
    path: @"..\..\..\src\szoftverek.txt",
    encoding: Encoding.UTF8);
_ = sr.ReadLine();
var lista = new List<Szoftverek>();
while (!sr.EndOfStream)
{
    lista.Add(new Szoftverek(sr.ReadLine()));
}
foreach (var s in lista) Console.WriteLine(s);

Console.WriteLine($"7. feladat \n {FM.tarolo(lista)} db");
Console.WriteLine("8. feladat");
FM.Ertekeles(lista);
var v = lista.Where(x => x.NevEsVerzio.StartsWith("Adobe")).ToList();
foreach (var x in v)
{
    Console.WriteLine(x + $"| Bruttó ár: {x.BruttoAr}");
}