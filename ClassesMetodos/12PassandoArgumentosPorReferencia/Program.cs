Console.WriteLine("## Passando argumentos por valor ##\n");

int x = 20;

Console.WriteLine("\nValor do argumento x antes de passar por referência " + x);

Calculo calc = new();
calc.Dobrar(ref x);

Console.WriteLine("\nValor do argumento x depois de passar por referência " + x);

Console.ReadKey();

public class Calculo
{
    public void Dobrar(ref int y)
    {
        y *= 2;
        Console.WriteLine("\nValor do parâmetro y no método Dobrar " + y);
    }
}