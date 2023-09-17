Console.WriteLine("## Exercício Prático 08 ##\n");

Cliente cliente = new("Lucas", "lucas@email.com", 29);
Cliente.ExibirInfo(email: cliente.Email, nome: cliente.Nome, idade: cliente.Idade);
Cliente.ExibirInfo(email: cliente.Email, nome: cliente.Nome);

Console.ReadKey();

public struct Cliente
{
    public string Nome;
    public string Email;

    private int idade;
    public int Idade
    {
        get { return idade; }
        set
        {
            if (value < 18)
            {
                idade = 18;
            }
            else
            {
                idade = value;
            }
        }
    }

    public Cliente(string? nome, string? email, int idade)
    {
        Nome = nome;
        Email = email;
        Idade = idade;
    }

    public static void ExibirInfo(string nome, string email, int idade = 18)
    {
        Console.WriteLine($"{nome} {email} {idade}");
    }
}