Console.WriteLine("## Herança ##\n");

Aluno aluno1 = new();
Aluno aluno = new("José");

Console.ReadKey();

public class Pessoa
{
    public Pessoa()
    {
        Console.WriteLine("construtor da classe Pessoa");
    }
    public Pessoa(string nome)
    {
        Console.WriteLine("construtor da classe Pessoa com parâmetro");
    }
}

public class Aluno : Pessoa
{
    public Aluno() : base()
    {
        Console.WriteLine("construtor da classe Aluno");
    }
    public Aluno(string nome) : base(nome)
    {
        Console.WriteLine("construtor da classe Aluno com parâmetro");
    }
}