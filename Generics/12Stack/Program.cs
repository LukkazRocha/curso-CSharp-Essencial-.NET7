
//Stack<int> numeros = new Stack<int>();
//numeros.Push(1);

//int[] array1 = new int[] { 1, 2, 3, 4 };
//Stack<int> pilha1 = new Stack<int>(array1);

//var impares = new Stack<int>(3);
//impares.Push(1);

Stack<int> numeros = new Stack<int>();
numeros.Push(10);
numeros.Push(20);
numeros.Push(30);
numeros.Push(10);

Console.WriteLine($"-A pilha original contém {numeros.Count} items");

ExibirPilha(numeros);

//Retornar elemento sem remover
Console.WriteLine($"\nItem obtido da pilha (Peek) : {numeros.Peek()}");

//Remover e retornar
Console.WriteLine($"\nItem removido da pilha (Pop) : {numeros.Pop()}");

ExibirPilha(numeros);

if (numeros.Contains(20))
{
    Console.WriteLine("\nItem 20 está na pilha");
}
else
{
    Console.WriteLine("\nItem 20 não está na pilha");
}

Console.WriteLine("\n-Copia a pilha usando ToArray");
var copia = new Stack<int>(numeros.ToArray());
ExibirPilha(copia);

Console.WriteLine("\n-Removendo todos os itens da pilha\n");
numeros.Clear();
Console.WriteLine($"{numeros.Count} items na pilha");

ExibirPilha(numeros);

Console.ReadKey();

static void ExibirPilha<T>(IEnumerable<T> colecao)
{
    foreach (var item in colecao)
    {
        Console.WriteLine(item);
    }
}