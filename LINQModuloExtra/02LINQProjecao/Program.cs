using _02LINQProjecao;

Console.WriteLine("## LINQ - Operadores de Projeção ##\n");

//Sintaxe de método
//IEnumerable<string> nomes = FonteDados.GetAlunos().Select(n => n.Nome);

//Console.WriteLine("Alunos\n");
//foreach (var nome in nomes)
//{
//    Console.WriteLine(nome);
//}

///////////////////////////////////////////////////////

//List<Aluno> lista = FonteDados.GetAlunos().Select(a => new Aluno()
//{
//    Nome = a.Nome,
//    Idade = a.Idade
//}).ToList();

//Console.WriteLine("\nAlunos idade");
//foreach (var aluno in lista)
//{
//    Console.WriteLine($"{aluno.Nome} : {aluno.Idade}");
//}

///////////////////////////////////////////////////////

//var listaTipoAnonimo = FonteDados.GetAlunos().Select(a => new
//{
//    NomeAluno = a.Nome,
//    IdadeAluno = a.Nota,
//    NotaAluno = a.Nota
//}).ToList();

//Console.WriteLine("\nAlunos Idade");
//foreach (var aluno in listaTipoAnonimo)
//{
//    Console.WriteLine($"{aluno.NomeAluno} : {aluno.IdadeAluno}");
//}

///////////////////////////////////////////////////////

//var funcionariosTipoAnonimo = FonteDados.GetFuncionarios().Select(f => new
//{
//    NomeFuncionario = f.Nome,
//    IdadeFuncionario = f.Idade,
//    SalarioAnual = f.Salario * 12
//});

//Console.WriteLine("Nome Idade Salario Anual");
//foreach (var funcionario in funcionariosTipoAnonimo)
//{
//    Console.WriteLine($"{funcionario.NomeFuncionario} : {funcionario.IdadeFuncionario} {funcionario.SalarioAnual:c}");
//}

///////////////////////////////////////////////////////

//SelectMany
//List<List<int>> listas = new()
//{
//    new () {1, 2, 3},
//    new () {12},
//    new () {5, 6, 5, 7},
//    new () {10, 10, 10, 13}
//};

//IEnumerable<int> resultado = listas.SelectMany(lista => lista.Distinct());

//foreach (var i in resultado)
//{
//    Console.Write($"{i} ");
//}

///////////////////////////////////////////////////////

// usando Select
IEnumerable<List<string>> retornoSelect = FonteDados.GetAlunos().Select(c => c.Cursos);
foreach (List<string> listaCursos in retornoSelect)
{
    foreach (string curso in listaCursos)
    {
        Console.Write($"{curso} ");
    }
    Console.WriteLine();
}

// usando SelecMany
Console.WriteLine("\nUsando SelectMany\n");
IEnumerable<string> retornoSelectMany = FonteDados.GetAlunos().SelectMany(c => c.Cursos);
foreach (string curso in retornoSelectMany)
{
    Console.Write($"{curso} ");
}

Console.ReadKey();