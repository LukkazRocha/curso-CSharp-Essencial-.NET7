Console.WriteLine("## LINQ ##\n");

List<string> frutas = new() { "Banana", "Maçã", "Pera", "Laranja", "Uva" };

//query syntax

var resultado = from f in frutas
                where f.Contains('r')
                select f;

Console.WriteLine(String.Join(" - ", resultado));

//method syntax
var resultado2 = frutas.Where(f => f.Contains('r'));
Console.WriteLine(String.Join(" - ", resultado2));

Console.ReadKey();