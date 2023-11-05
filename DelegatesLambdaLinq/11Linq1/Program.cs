List<string> nomes = new List<string>()
{
    "Ana", "Maria", "Pedro", "Lair", "Hugo"
};

//sintaxe de consulta
var resultado = from m in nomes
                where m.Contains('o')
                select m;

ExibirResultado(resultado);

//sintaxe de método
var resultado1 = nomes.Where(m => m.Contains('a'));

ExibirResultado(resultado1);

Console.ReadKey();

static void ExibirResultado(IEnumerable<string> resultado)
{
    Console.WriteLine();
    foreach (var item in resultado)
    {
        Console.WriteLine(item);
    }
}