using _04LINQ_OperacoesConjunto2;

Console.WriteLine("## LINQ - Operações com conjuntos ## \n");

//string[] fonte1 = { "Brasil", "USA", "UK", "Argentina", "China" };
//string[] fonte2 = { "Brasil", "uk", "Argentina", "França", "Japão" };

//var resultado = fonte1.Intersect(fonte2, StringComparer.OrdinalIgnoreCase).ToList();

//foreach (var pais in resultado)
//{
//    Console.Write($"{pais} ");

//}

////////////////////////////////////////////////////////

//var turmaA = FonteDados.GetTurmaA();
//var turmaB = FonteDados.GetTurmaB();

//var consulta2 = turmaA.Select(p => p.Nascimento.Year).Intersect(turmaB.Select(p => p.Nascimento.Year));

//var alunosTurmaAComMesmoAnoNascimento = turmaA.IntersectBy(turmaB.Select(p => p.Nascimento.Year), p => p.Nascimento.Year);

//Console.WriteLine("Turma A - Alunos com mesmo ano de nascimento da turma B\n");

//foreach (var aluno in alunosTurmaAComMesmoAnoNascimento)
//{
//    Console.WriteLine($"{aluno.Nome} ");
//}
//Console.WriteLine($"\nTotal de alunos: {alunosTurmaAComMesmoAnoNascimento.Count()}");

////////////////////////////////////////////////////////

//List<int> fonte1 = new() { 1, 2, 3, 4, 5, 6 };
//List<int> fonte2 = new() { 1, 3, 5, 8, 9, 10 };

//var resultado = fonte1.Union(fonte2).ToList();

//foreach (var item in resultado)
//{
//    Console.Write($"{item} ");
//}

////////////////////////////////////////////////////////

//string[] fonte1 = { "Brasil", "USA", "UK", "Argentina", "China" };
//string[] fonte2 = { "Brasil", "uk", "Argentina", "França", "Japão" };

//var resultado = fonte1.Union(fonte2, StringComparer.OrdinalIgnoreCase).ToList();

//foreach (var pais in resultado)
//{
//    Console.Write($"{pais} ");
//}

////////////////////////////////////////////////////////

var turmaA = FonteDados.GetTurmaA();
var turmaB = FonteDados.GetTurmaB();

var consultaUnion = turmaA.Select(p => p.Nome).Union(turmaB.Select(p => p.Nome));

var turmasUnionBy = turmaA.UnionBy(turmaB, p => p.Nome);

Console.WriteLine("Alunos nomes distintos\n");

foreach (var aluno in turmasUnionBy)
{
    Console.WriteLine($"{aluno.Nome} {aluno.Nascimento.Year} {aluno.Idade}");
}

Console.ReadKey();