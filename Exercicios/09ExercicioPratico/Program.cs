using _09ExercicioPratico;

Console.WriteLine("## Exercício Prático 09 ##\n");

Console.WriteLine($"{Cores.Branco} - {(int)Cores.Branco}");
Console.WriteLine($"{Cores.Vermelho} - {(int)Cores.Vermelho}");
Console.WriteLine($"{Cores.Preto} - {(int)Cores.Preto}");
Console.WriteLine($"{Cores.Cinza} - {(int)Cores.Cinza}");
Console.WriteLine($"{Cores.Prata} - {(int)Cores.Prata}");
Console.WriteLine($"{Cores.Azul} - {(int)Cores.Azul}");


Console.WriteLine($"\nSelecione a cor do carro");
int cor = Convert.ToInt32(Console.ReadLine());

Carro chevrolet = new("Sedan", "Chevrolet", "Onix", 2016, 110, cor);
chevrolet.ExibirInfo(chevrolet.Modelo, chevrolet.Montadora, chevrolet.Marca, chevrolet.Ano, chevrolet.Potencia, chevrolet.Cor);

Console.ReadKey();

public class Carro
{
    public string? Modelo;
    public string? Montadora;
    public string? Marca;
    public int Ano;
    public int Potencia;
    public int Cor;

    public Carro(string? modelo, string? montadora, string? marca, int ano, int potencia, int cor)
    {
        Modelo = modelo;
        Montadora = montadora;
        Marca = marca;
        Ano = ano;
        Potencia = potencia;
        Cor = cor;
    }

    public void ExibirInfo(string? modelo, string? montadora, string? marca, int ano, int potencia, int cor)
    {
        Console.WriteLine(modelo);
        Console.WriteLine(montadora);
        Console.WriteLine(marca);
        Console.WriteLine(ano);
        Console.WriteLine(potencia);
        Console.WriteLine((Cores)cor);
    }
}