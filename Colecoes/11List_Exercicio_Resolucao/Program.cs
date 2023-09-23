using _11List_Exercicio_Resolucao;

List<Aluno> alunos = FonteDados.GetAlunos();

ExibirAlunos(alunos);

Aluno bia = new Aluno() { Nome = "Bia", Nota = 7.75 };
Aluno mario = new Aluno() { Nome = "Mario", Nota = 8.95 };
alunos.Add(bia);
alunos.Add(mario);

ExibirAlunos(alunos);

var aluno1 = alunos.Find(n => n.Nome.Equals("Amanda"));
alunos.Remove(aluno1);

ExibirAlunos(alunos);

//alunos.Sort();
var listaOrdenada = alunos.OrderBy(x => x.Nome).ToList();

ExibirAlunos(listaOrdenada);

var alunosNotaOito = alunos.FindAll(n => n.Nota >= 8);


Console.Write("\nAlunos com nota maior que 8\n");
foreach (var item in alunosNotaOito)
{
    Console.WriteLine($"{item.Nome}\t{item.Nota}");
}

Console.ReadKey();

static void ExibirAlunos(List<Aluno> alunos)
{
    Console.WriteLine("\nRelação de alunos\n");
    Console.WriteLine("\nNome\tNota");

    var somaNotas = 0.0;
    foreach (var aluno in alunos) 
    {
        Console.WriteLine($"{aluno.Nome}\t{aluno.Nota}");
        somaNotas += aluno.Nota;
    }

    var mediaNotas = somaNotas / alunos.Count();
    Console.WriteLine($"\nMédia das notas : {Math.Round(mediaNotas, 2)}");
    Console.WriteLine($"\nTotal de alunos : {alunos.Count()}");
}