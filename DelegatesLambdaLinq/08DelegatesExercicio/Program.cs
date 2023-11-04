using _08DelegatesExercicio;

var listaPessoas = Pessoa.GetPessoas();

Console.WriteLine("1- Imprime o nome/idade de cada pessoa usando um delegate Action<Pessoa>");

Action<Pessoa> imprimirNome = p => Console.WriteLine(p.Nome + " " + p.Idade);
listaPessoas.ForEach(imprimirNome);

Console.WriteLine("2- Filtrar pessoas maiores de 18 anos usando um delegate Predicate<Pessoa>");

Predicate<Pessoa> filtrarIdadeMaiorQue18 = p => p.Idade > 18;
var pessoasMaiores18Anos = listaPessoas.FindAll(filtrarIdadeMaiorQue18);

pessoasMaiores18Anos.ForEach(imprimirNome);

Console.WriteLine("3- Obtém nome/idade da pessoa mais velha utilizando um delegate Func<Pessoa>");

Func<Pessoa, int> obterIdade = p => p.Idade;

var pessoaMaisVelha = listaPessoas.MaxBy(obterIdade);

//int idadeMaxima = listaPessoas.Max(obterIdade);

//var pessoaMaisVelha = listaPessoas.Find(p => p.Idade == idadeMaxima);

Console.WriteLine("A pessoa mais velha é: " + pessoaMaisVelha.Nome + " idade: " + pessoaMaisVelha.Idade);

Console.ReadKey();
