using _11Exercicio;

Console.WriteLine("## Exercício ##\n");

List<Aluno> alunos = new()
{
    new Aluno("Maria", 8.75),
    new Aluno("Manoel", 6.95),
    new Aluno("Amanda", 7.25),
    new Aluno("Carlos", 6.55),
    new Aluno("Jaime", 8.50),
    new Aluno("Debora", 5.95),
    new Aluno("Alicia", 9.25),
    new Aluno("Sandra", 5.55),
    new Aluno("Marta", 7.85),
    new Aluno("Sueli", 9.15)
};

ExibirAlunos(alunos);

alunos.Add(new Aluno("Bia", 7.75));
alunos.Add(new Aluno("Mario", 8.95));

Console.WriteLine();
ExibirAlunos(alunos);

var aluno1 = alunos.Find(f => f.Nome == "Amanda");

if (aluno1 != null) alunos.Remove(aluno1);

Console.WriteLine();
ExibirAlunos(alunos);

var listaOrdenada = alunos.OrderBy(f => f.Nome).ToList();

Console.WriteLine();
ExibirAlunos(listaOrdenada);

var notaMaiorIgualA8 = listaOrdenada.FindAll(f => f.Nota >= 8.00);

Console.WriteLine();
ExibirAlunos(notaMaiorIgualA8);

static void ExibirAlunos(List<Aluno> alunos)
{
    double somaNotas = 0.0;

    foreach (var aluno in alunos)
    {
        Console.WriteLine($"Nome: {aluno.Nome} - Nota: {aluno.Nota} ");
        somaNotas += aluno.Nota;
    }

    double media = somaNotas / alunos.Count;

    Console.WriteLine("\nMédia: " + media.ToString("F2"));
    Console.WriteLine("Total de alunos: " + alunos.Count);
}