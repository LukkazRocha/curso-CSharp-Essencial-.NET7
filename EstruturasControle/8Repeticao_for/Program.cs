Console.WriteLine("## Instrução for ##\n");

int resultado, numero;

Console.WriteLine("Informe o número inteiro: \t");
numero = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= 10; i++)
{
    resultado = numero * i;
    Console.WriteLine($"{numero} X {i} = {resultado}");
}

Console.WriteLine("\nFim do processamento...");
Console.ReadKey();
