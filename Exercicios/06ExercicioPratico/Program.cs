Console.WriteLine("## Exercício Prático 06 ##\n");

Carro chevrolet = new Carro();
chevrolet.Modelo = "Sedan";
chevrolet.Montadora = "Chevrolet";
chevrolet.Marca = "Onix";
chevrolet.Ano = 2016;
chevrolet.Potencia = 110;

var Ipva = Carro.ObterValorIPVA();
Console.WriteLine(Ipva);

public class Carro
{
    public string? Modelo;
    public string? Montadora;
    public string? Marca;
    public int Ano;
    public int Potencia;
    public static double ValorIpva;

    public static double ObterValorIPVA()
    {
        return ValorIpva = 4;
    }
}