
//var numeros = new SortedSet<int>() { 1, 5, 3, 4, 2 };
//ExibirColecao(numeros);

//var frutas = new SortedSet<string>() { "uva", "banana", "pera", "kiwi" };
//ExibirColecao(frutas);

//SortedSet<int> pares = new SortedSet<int>();
//for (int i = 6; i > 0; i--)
//{
//    pares.Add(i * 2);
//}
//ExibirColecao(pares);

var numeros = new List<int>() { 1, 7, 3, 6, 5, 4, 2 };
SortedSet<int> conjunto = new SortedSet<int>(numeros);
ExibirColecao(conjunto);

var frutas = new List<string>() { "uva", "banana", "pera", "manga" };
SortedSet<string> minhasFrutas = new SortedSet<string>(frutas);
ExibirColecao(minhasFrutas);

var impares = new int[] { 1, 13, 7, 9, 11, 13, 5 };
SortedSet<int> meusNumeros = new SortedSet<int>(impares);
ExibirColecao(meusNumeros);

Console.ReadKey();

static void ExibirColecao<T>(IEnumerable<T> colecao)
{
    Console.WriteLine();
    foreach (var item in colecao)
    {
        Console.WriteLine(item);
    }
}