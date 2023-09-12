Console.WriteLine("## Exercício Prático 05 ##\n");

Carro chevrolet = new Carro();

chevrolet.ExibirInfo("Sedan", "Chevrolet", "Onix", 110, 2016);
Console.WriteLine();
chevrolet.ExibirInfo("Sedan", "Chevrolet", "Onix", 110);

public class Carro
{
    public string? Modelo;
    public string? Montadora;
    public string? Marca;
    public int Ano;
    public int Potencia;

    public void ExibirInfo(string modelo, string montadora, string marca, int potencia, int ano = 2010)
    {
        Console.WriteLine($"Modelo: {modelo} \nMontadora: {montadora} \nMarca: {marca} \nAno: {ano} \nPotência: {potencia}");
    }
}