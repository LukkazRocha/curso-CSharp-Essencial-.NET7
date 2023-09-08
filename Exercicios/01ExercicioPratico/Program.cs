Console.WriteLine("## Exercício Prático 01 ##\n");

//Carro chevrolet = new Carro();
//chevrolet.modelo = "Sedan";
//chevrolet.montadora = "Chevrolet";
//chevrolet.marca = "Onix";
//chevrolet.ano = 2016;
//chevrolet.potencia = 110;

//Carro ford = new Carro();
//ford.modelo = "SUV";
//ford.montadora = "Ford";
//ford.marca = "EcoSport";
//ford.ano = 2018;
//ford.potencia = 120;

//Console.WriteLine(chevrolet.modelo);
//Console.WriteLine(chevrolet.montadora);
//Console.WriteLine(chevrolet.marca);
//Console.WriteLine(chevrolet.ano);
//Console.WriteLine(chevrolet.potencia);
//chevrolet.Acelerar(chevrolet.marca);

//Console.WriteLine();

//Console.WriteLine(ford.modelo);
//Console.WriteLine(ford.montadora);
//Console.WriteLine(ford.marca);
//Console.WriteLine(ford.ano);
//Console.WriteLine(ford.potencia);
//ford.Acelerar(ford.marca);

///////////////////////////////////////

Carro chevrolet = new Carro("Sedan", "Chevrolet", "Onix", 2016, 110);
Carro ford = new Carro("SUV", "Ford", "EcoSport", 2018, 120);

Console.WriteLine($"{chevrolet.modelo} {chevrolet.montadora} {chevrolet.marca} {chevrolet.ano} {chevrolet.potencia} CV");
chevrolet.Acelerar(chevrolet.marca);

Console.WriteLine($"{ford.modelo} {ford.montadora} {ford.marca} {ford.ano} {ford.potencia} CV");
ford.Acelerar(ford.marca);

public class Carro
{
    public string? modelo;
    public string? montadora;
    public string? marca;
    public int ano;
    public int potencia;

    public Carro(string? modelo, string? montadora, string? marca, int ano, int potencia)
    {
        this.modelo = modelo;
        this.montadora = montadora;
        this.marca = marca;
        this.ano = ano;
        this.potencia = potencia;
    }

    public void Acelerar(string marca)
    {
        Console.WriteLine($"Acelerando o meu {marca}\n");
    }
}