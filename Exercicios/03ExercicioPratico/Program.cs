Console.WriteLine("## Exercício Prático 03 ##\n");

Carro chevrolet = new Carro("Sedan", "Chevrolet", "Onix", 2016, 110);
Carro ford = new Carro("SUV", "Ford", "EcoSport", 2018, 120);


//por valor
Console.WriteLine("Aumentando a potência (por valor : + 3CV : ");
var novaPotenciaChevrolet = chevrolet.AumentarPotencia(chevrolet.Potencia);

Console.WriteLine("-> " + novaPotenciaChevrolet);
Console.WriteLine("\nO valor do campo Potencia não foi alterado : " + chevrolet.Potencia);

Console.WriteLine("\n======================================\n");

//por referência
Console.WriteLine("Aumentando a potência (por referência : + 5CV : ");
var novaPotenciaFord = ford.AumentarPotencia(ref ford.Potencia);

Console.WriteLine("-> " + novaPotenciaFord);
Console.WriteLine("\nO valor do campo Potencia foi alterado : " + ford.Potencia);

//chevrolet.VelocidadeMaxima(chevrolet.Potencia);
//ford.VelocidadeMaxima(ford.Potencia);

public class Carro
{
    public string? Modelo;
    public string? Montadora;
    public string? Marca;
    public int Ano;
    public int Potencia;

    public Carro(string? modelo, string? montadora)
    {
        Modelo = modelo;
        Montadora = montadora;
    }

    public Carro(string? modelo, string? montadora, string? marca, int ano, int potencia)
    {
        Modelo = modelo;
        Montadora = montadora;
        Marca = marca;
        Ano = ano;
        Potencia = potencia;
    }

    public void Acelerar(string marca)
    {
        Console.WriteLine($"Acelerando o meu {marca}\n");
    }

    public double VelocidadeMaxima(int potencia)
    {
        return potencia * 1.75;
    }

    public int AumentarPotencia(int potencia)
    {
        return potencia += 3;
    }

    public int AumentarPotencia(ref int potencia)
    {
        return potencia += 5;
    }
}