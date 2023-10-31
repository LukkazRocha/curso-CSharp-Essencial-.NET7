List<string> nomes = new()
{
    "Maria",
    "Miriam",
    "Paulo",
    "Carlos"
};

//string resultado = nomes.Find(delegate (string nome)
//{
//    return nome.Equals("Paulo");
//});

//string? resultado = nomes.Find(VerificaNomeNaLista);

string? resultado = nomes.Find(x => x.Equals("Paulo"));

Console.WriteLine(resultado);

Console.ReadKey();

static bool VerificaNomeNaLista(string nome)
{
    return nome.Equals("Paulo");
}