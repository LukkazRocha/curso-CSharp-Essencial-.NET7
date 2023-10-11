﻿Console.WriteLine("### Alunos e Notas ###\n");

var alunos = new Dictionary<int, Aluno>()
{
    { 1, new Aluno("Maria", 7) },
    { 2, new Aluno("Eric", 8) },
    { 3, new Aluno("Ana", 9) },
    { 4, new Aluno("Alex", 6) },
    { 5, new Aluno("Diná", 5) }
};

ExibirColecao(alunos);
do
{
    Console.WriteLine("\nInforme o código do aluno a localizar (99 sai)");
    int codigo = Convert.ToInt32(Console.ReadLine());

    if (codigo == 99) break;

    var resultado = alunos.ContainsKey(codigo);
    if (resultado)
    {
        Console.WriteLine("Informe a nota (1 a 10)");
        var nota = Convert.ToInt32(Console.ReadLine());
        alunos[codigo].Nota = nota;
    }
    else
    {
        Console.WriteLine("Aluno não localizado");
    }
} while (true);
ExibirColecao(alunos);

Console.WriteLine("\nInforme o código do aluno a remover");
int cod = Convert.ToInt32(Console.ReadLine());
if (alunos.ContainsKey(cod))
{
    alunos.Remove(cod);
    Console.WriteLine("\nAluno removido com sucesso");
}
else
{
    Console.WriteLine("\nCódigo não encontrado");
}

ExibirColecao(alunos);

Console.WriteLine("\n### Incluindo novo aluno ###");
Console.WriteLine("\nInforme o nome do aluno");
string novoNome = Console.ReadLine();

Console.WriteLine("\nInforme a nota do aluno");
int novaNota = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o código do aluno");
int novoCodigo = Convert.ToInt32(Console.ReadLine());

if (!alunos.ContainsKey(novoCodigo))
{
    alunos.Add(novoCodigo, new Aluno(novoNome, novaNota));
    Console.WriteLine("Aluno incluído com sucesso");
}
else
{
    Console.WriteLine("Código já existe");
}
ExibirColecao(alunos);

Console.WriteLine("\nAlunos ordenados por nome");

var alunosOrdenados = alunos.OrderBy(x => x.Value.Nome);

foreach (var aluno in alunosOrdenados)
{
    Console.WriteLine($"{aluno.Key} {aluno.Value.Nome} {aluno.Value.Nota}");
}

alunos.Clear();

ExibirColecao(alunos);
Console.WriteLine("Fim do exercício");

Console.ReadKey();

static void ExibirColecao(Dictionary<int, Aluno> alunos)
{
    foreach (var aluno in alunos)
    {
        Console.WriteLine($"{aluno.Key} {aluno.Value.Nome} {aluno.Value.Nota}");
    }
}

public class Aluno
{
    public Aluno(string? nome, int nota)
    {
        Nome = nome;
        Nota = nota;
    }

    public string? Nome { get; set; }

    public int Nota { get; set; }
}