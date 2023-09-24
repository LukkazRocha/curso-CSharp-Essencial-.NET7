Console.WriteLine("## Exercício Prático 11 ##\n");

string[] frutas = new string[]
{
    "Maçã", "Banana", "Laranja", "Uva", "Manga", "Pêra", "Abacate", "Mamão", "Pêssego", "Amora"
};


Console.WriteLine("\nExibe as frutas com laço for:\n");
for (int i = 0; i < frutas.Length; i++)
{
    Console.Write($"{frutas[i]} ");
}
Console.WriteLine($"\nTotal de frutas: {frutas.Length}");

Console.WriteLine("\nExibe as frutas com laço foreach:\n");

ExibirFrutas(frutas);

Console.WriteLine($"\nTotal de frutas: {frutas.Length}");

Console.WriteLine("\nExibe o nome da segunda e penúltima fruta:\n");
Console.WriteLine(frutas[1]);
Console.WriteLine(frutas[8]);

Console.WriteLine("\nAlterando o nome da terceira e última fruta:\n");
frutas[2] = "Kiwi";
frutas[9] = "Caqui";

ExibirFrutas(frutas);

Console.WriteLine("\nOrdene a coleção de frutas:\n");
Array.Sort(frutas);

ExibirFrutas(frutas);

Console.WriteLine("\nOrdene a coleção de frutas na ordem inversa\n");
Array.Reverse(frutas);

ExibirFrutas(frutas);

Console.ReadKey();

static void ExibirFrutas(string[] frutas)
{
    foreach (var fruta in frutas)
    {
        Console.Write($"{fruta} ");
    }
}