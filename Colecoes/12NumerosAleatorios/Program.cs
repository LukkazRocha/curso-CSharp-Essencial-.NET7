Console.WriteLine("## Números aleatórios ##\n");

//byte[] randBytes = new byte[10];
//Random random = new Random(2023);
//random.NextBytes(randBytes);

////Console.WriteLine(random.Next());
////Console.WriteLine(random.Next(20)); //valor máximo
////Console.WriteLine(random.Next(10, 20));//mínimo e máximo (pode incluir o mínimo mas não o máximo)
////Console.WriteLine(random.NextDouble());

//for (int i = 0; i < 6; i++)
//{
//    Console.WriteLine(randBytes[i]);
//}


////////////////////////////////////////////


Console.WriteLine("Sorteio da MegaSena\n");

Random random = new Random();
int[] numerosSorteados = new int[6];

for (int i = 0; i < 6; i++)
{
    int numeroAleatorio;
    do
    {
        numeroAleatorio = random.Next(1, 61);
    }
    while (numerosSorteados.Contains(numeroAleatorio));

    numerosSorteados[i] = numeroAleatorio;
}

Array.Sort(numerosSorteados);

Console.WriteLine("Números Sorteados\n");

Console.WriteLine(string.Join(" ", numerosSorteados));

Console.ReadKey();