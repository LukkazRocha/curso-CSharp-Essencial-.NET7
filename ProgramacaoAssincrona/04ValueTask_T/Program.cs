
Console.WriteLine("Informe o primeiro número inteiro");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o segundo número inteiro");
int num2 = Convert.ToInt32(Console.ReadLine());

var soma = await CalcularSoma(num1, num2);

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine($"\n {num1} + {num2} = {soma}");

Console.ReadKey();

static async Task<int> CalcularSoma(int num1, int num2)
{
    if (num1 == 0 && num2 == 0) return 0;

    return await Task.Run(() => num1 + num2);
}