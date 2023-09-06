Console.WriteLine("## Métodos ##\n");

MinhaClasse minhaClasse = new MinhaClasse();

var nomeCliente = "Maria";
var dataAtual = DateTime.Now.ToShortDateString();

//valores dos argumentos
minhaClasse.Saudacao(nomeCliente, dataAtual);

Console.ReadKey();

class MinhaClasse
{
    //os parâmetros do método
    public void Saudacao(string nome, string data)
    {
        Console.WriteLine(nome);
        Console.WriteLine(data);
    }
}