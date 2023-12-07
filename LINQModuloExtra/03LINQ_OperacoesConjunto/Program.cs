using _03LINQ_OperacoesConjunto;

Console.WriteLine("## LINQ - Operações com conjuntos ##\n");

//Console.WriteLine("idades -> 30, 33, 35, 36, 40, 30 , 33, 36, 30, 40\n");

//var idadesDistintas = FonteDados.GetIdades().Distinct();

//foreach (var idade in idadesDistintas)
//{
//    Console.Write($"{idade} ");
//}

//Console.WriteLine("Paulo, MARIA, paulo, Amanda, maria, amanda\n");

//var nomesDistintos = FonteDados.GetNomes().Distinct(StringComparer.OrdinalIgnoreCase);

//foreach (var nomes in nomesDistintos)
//{
//    Console.Write($"{nomes} ");
//}

var alunos = FonteDados.GetAlunos();

var alunosIdadesDistintas = alunos.DistinctBy(a => a.Idade);

foreach (var aluno in alunosIdadesDistintas)
{
    Console.WriteLine($"Aluno {aluno.Nome} tem {aluno.Idade} anos");
}

Console.ReadKey();