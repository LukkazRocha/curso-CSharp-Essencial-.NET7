//Imprimir imprimir = delegate (int valor)
//{
//    Console.WriteLine($"Método Anônimo: {valor}");
//};

//imprimir(100);
//imprimir(200);

List<string> nomes = new();
nomes.Add("Maria");
nomes.Add("Miriam");
nomes.Add("Paulo");
nomes.Add("Carlos");

//string resultado = nomes.Find(VerificaNomeNaLista);

string? resultado = nomes.Find(delegate (string nome)
{
    return nome.Equals("Paulo");
});

Console.WriteLine(resultado);

Console.ReadKey();

//public delegate void Imprimir(int valor);