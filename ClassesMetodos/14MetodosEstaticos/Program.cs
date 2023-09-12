Console.WriteLine("## Métodos estáticos ##\n");

var soma = Calculadora.Somar(10, 10);
var subtracao = Calculadora.Subtrair(10, 10);
var multiplicacao = Calculadora.Multiplicar(10, 10);
var divisao = Calculadora.Dividir(10, 10);

Console.WriteLine(soma);
Console.WriteLine(subtracao);
Console.WriteLine(multiplicacao);
Console.WriteLine(divisao);

Console.ReadKey();

public class Calculadora
{
    public static int Somar(int n1, int n2)
    {
        return n1 + n2;
    }

    public static int Subtrair(int n1, int n2)
    {
        return n1 - n2;
    }

    public static int Multiplicar(int n1, int n2)
    {
        return n1 * n2;
    }

    public static int Dividir(int n1, int n2)
    {
        return n1 / n2;
    }
}