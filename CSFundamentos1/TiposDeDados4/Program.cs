Console.WriteLine("Definindo variáveis do tipo string e object e dynamic");
Console.WriteLine();

string nome = "Curso C#";
String titulo = "Curso C# Essencial";

Console.WriteLine(nome);
Console.WriteLine(titulo);

string valor = "Isto é uma string";
valor = "Isto é uma string alterada";
valor = "teste";
// Foram criados 3 locais na memória com as variáveis chamadas valor pois o tipo string é imutável, ele não pode ser alterado.

//object nota = 10;
//object valor1 = 8.55m;
//object nome1 = "Maria";
//object ativa = true;
//object letra = 'A';

dynamic nota = 10;
dynamic valor1 = 8.55m;
dynamic nome1 = "Maria";
dynamic ativa = true;
dynamic letra = 'A';

Console.WriteLine(nota);
Console.WriteLine(valor1);
Console.WriteLine(nome1);
Console.WriteLine(ativa);
Console.WriteLine(letra);


Console.ReadLine();
