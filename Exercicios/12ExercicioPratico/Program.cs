Console.WriteLine("## Exercício Prático 12 ##\n");

Console.WriteLine("\nInforme o número de elementos inteiros no array");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\nInforme os valores dos números no array\n");

int[] numeros = new int[x];

for (int i = 0; i < x; i++)
{
    Console.Write($"numeros[{i}] = ");
    numeros[i] = Convert.ToInt32(Console.ReadLine());
}

string numero;

Console.WriteLine("\nInforme o número a localizar no array (Tecle fim para encerrar) : \n");
do
{
    numero = Console.ReadLine();

    if (numero != "fim")
    {
        int valor = Convert.ToInt32(numero);

        if (Array.BinarySearch(numeros, valor) >= 0)
        {
            Console.WriteLine($"\nO número {numero} Existe no array");
        }
        else
        {
            Console.WriteLine($"\nO número {numero} NÃO Existe no array");
        }
    }
}
while (numero != "fim");