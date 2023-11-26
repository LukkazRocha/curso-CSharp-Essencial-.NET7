Console.WriteLine("## LINQ ##\n");

List<string> frutas = new() { "Banana", "Maçã", "Pera", "Laranja", "Uva" };

//query syntax

var resultado = from f in frutas
                where f.Contains('r')
                select f;

Console.WriteLine(String.Join(" ", resultado));

Console.ReadKey();