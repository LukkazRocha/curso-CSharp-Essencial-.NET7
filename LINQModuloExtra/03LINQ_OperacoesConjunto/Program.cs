using _03LINQ_OperacoesConjunto;

Console.WriteLine("## LINQ - Operações com conjuntos ##\n");

//Console.WriteLine("idades -> 30, 33, 35, 36, 40, 30 , 33, 36, 30, 40\n");

//var idadesDistintas = FonteDados.GetIdades().Distinct();

//foreach (var idade in idadesDistintas)
//{
//    Console.Write($"{idade} ");
//}

//////////////////////////////////////

//Console.WriteLine("Paulo, MARIA, paulo, Amanda, maria, amanda\n");

//var nomesDistintos = FonteDados.GetNomes().Distinct(StringComparer.OrdinalIgnoreCase);

//foreach (var nomes in nomesDistintos)
//{
//    Console.Write($"{nomes} ");
//}

//////////////////////////////////////

//var alunos = FonteDados.GetAlunos();

//var alunosIdadesDistintas = alunos.DistinctBy(a => a.Idade);

//foreach (var aluno in alunosIdadesDistintas)
//{
//    Console.WriteLine($"Aluno {aluno.Nome} tem {aluno.Idade} anos");
//}

//////////////////////////////////////

//List<int> fonte1 = new() { 1, 2, 3, 4, 5, 6 };
//List<int> fonte2 = new() { 1, 3, 5, 8, 9, 10 };

//var resultado = fonte1.Except(fonte2).ToList();

//foreach (var item in resultado)
//{
//    Console.Write($"{item} ");
//}

//////////////////////////////////////

//string[] fonte1 = { "Brasil", "USA", "UK", "Argentina", "China" };
//string[] fonte2 = { "Brasil", "uk", "Argentina", "França", "Japão" };

//var resultado = fonte1.Except(fonte2, StringComparer.OrdinalIgnoreCase);

//foreach (var pais in resultado)
//{
//    Console.Write($"{pais} ");
//}

//////////////////////////////////////

var fonteDados = FonteDados.GetAlunos();

var alunosReprovados = new List<string>() { "Amanda", "Alicia", "Jaime" };

var alunosAprovados = fonteDados.ExceptBy(alunosReprovados, n => n.Nome);

Console.WriteLine("Alunos aprovados\n");
foreach (var aluno in alunosAprovados)
{
    Console.Write($"{aluno.Nome} ");
}

Console.ReadKey();