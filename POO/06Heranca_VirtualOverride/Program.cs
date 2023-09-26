Console.WriteLine("## Herança Virtual_Override ##\n");

Gato gato = new() { Nome = "Bichano" };
gato.ExibeNome();

Cachorro cao = new() { Nome = "Pipoca" };
cao.ExibeNome();

Console.ReadKey();

//classe base
class Animal
{
    public string? Nome { get; set; }
    public virtual void ExibeNome()
    {
        Console.WriteLine($"Meu nome é {Nome}");
    }
}

class Gato : Animal
{
    public override void ExibeNome()
    {
        Console.WriteLine($"\nEu sou um gato. Meu nome é: {Nome}");
    }
}

class Cachorro : Animal
{
}