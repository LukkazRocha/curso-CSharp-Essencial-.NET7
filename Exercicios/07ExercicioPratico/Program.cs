Console.WriteLine("## Exercício Prático 06 ##\n");

Carro chevrolet = new Carro();
chevrolet.Modelo = "Sedan";
chevrolet.Montadora = "Chevrolet";
chevrolet.Marca = "Onix";
chevrolet.Ano = 2025;
chevrolet.Potencia = 110;

var Ipva = Carro.ObterValorIPVA();
Console.WriteLine(Ipva);

public class Carro
{
    public string? Modelo;
    public string? Montadora;
    public string? Marca;
    public int Potencia;
    public static double ValorIpva;

    private int ano;
    public int Ano
    {
        get { return ano; }
        set
        {
            if (value < 2000)
            {
                ano = 2000;
            }
            else if (value > 2022)
            {
                ano = 2022;
            }
            else
            {
                ano = value;
            }
        }
    }

    public static double ObterValorIPVA()
    {
        return ValorIpva = 4;
    }
}