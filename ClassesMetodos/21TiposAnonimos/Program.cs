Console.WriteLine("## Tipos Anônimos ##\n");

//var aluno = new
//{
//    Nome = "Maria",
//    Idade = 43
//};

//Console.WriteLine(aluno.GetType().ToString());
//Console.WriteLine(aluno.Nome + " " + aluno.Idade);

////////////////////////////////////////////

//var aluno = new
//{
//    Id = 1,
//    Nome = "Jairo",
//    Email = "jairo@email.com",
//    Endereco = new { Id = 1, Cidade = "Santos", Pais = "Brasil" }
//};

//Console.WriteLine(aluno.Nome);
//Console.WriteLine(aluno.Endereco.Cidade);

////////////////////////////////////////////

var alunos = new[]
{
    new { Id = 1, Nome = "Maria", Email = "maria@emmail.com" },
    new { Id = 2, Nome = "Sonia", Email = "sonia@emmail.com" },
    new { Id = 3, Nome = "Bruno", Email = "bruno@emmail.com" }
};

Console.WriteLine(alunos[0].Nome);
Console.WriteLine(alunos[0].Email);

Console.ReadKey();