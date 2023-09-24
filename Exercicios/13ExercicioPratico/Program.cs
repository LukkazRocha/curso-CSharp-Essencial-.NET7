Console.WriteLine("## Exercício Prático 13 ##\n");

int totalAlunos = 5;
int totalGrupos = 2;

float[,] notas = new float[totalGrupos, totalAlunos];
float[] somaNotaGrupos = new float[totalGrupos];
float[] media = new float[totalGrupos];

for (int i = 0; i < totalGrupos; i++)
{
    Console.WriteLine($"\nInforme as notas do grupo{i + 1}");
    for (int j = 0; j < totalAlunos; j++)
    {
        Console.Write($"Nota [{i},{j}] = ");
        notas[i, j] = Convert.ToSingle(Console.ReadLine());
        somaNotaGrupos[i] += notas[i, j];
    }

    media[i] = somaNotaGrupos[i] / totalAlunos;
}

Console.WriteLine($"\nMédia grupo1 = {media[0]}\n");
Console.WriteLine($"Média grupo2 = {media[1]}");

Console.ReadKey();