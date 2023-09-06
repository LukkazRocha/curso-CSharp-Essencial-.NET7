Console.WriteLine("## Classes e Métodos ##\n");

int x = 100;

Pessoa p1 = new Pessoa();
p1.nome = "Maria";
p1.idade = 25;
p1.sexo = "feminino";

Console.WriteLine($"{p1.nome} {p1.idade} {p1.sexo}");

Pessoa p2 = new Pessoa();
p2.nome = "Manuel";
p2.idade = 23;
p2.sexo = "masculino";

Console.WriteLine($"{p2.nome} {p2.idade} {p2.sexo}");

Console.ReadKey();

class Pessoa
{
    public string? nome;
    public int idade;
    public string? sexo;
}
