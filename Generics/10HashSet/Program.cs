
var timesSP = new HashSet<string> { "Santos", "Palmeiras", "São Paulo" };
var timesRJ = new HashSet<string> { "Vasco", "Flamengo", "Fluminense" };
var timesBA = new HashSet<string> { "Bahia", "Vitória", "Juazeiro" };
var timesMundiais = new HashSet<string> { "Santos", "Palmeiras", "São Paulo", "Flamengo" };

if (!timesSP.Contains("Corinthians"))
{
    timesSP.Add("Corinthians");
}
//var resultado = timesBA.Remove("Juazeiro");

//Verifica se a coleção de timesSP esta contida em timesMundiais


////////////////////////////////////////////////



//if (timesSP.IsSubsetOf(timesMundiais))
//{
//    Console.WriteLine("timesSP é um subconjunto de timesMundiais\n");
//}

////Verifica se timesMundiais contem a coleção timesSP
//if (timesMundiais.IsSupersetOf(timesSP))
//{
//    Console.WriteLine("timesMundiais é um superconjunto de timesSP\n");
//}

////Verifica se existem elementos em comum entre timesRJ e timesMundiais
//if (timesRJ.Overlaps(timesMundiais))
//{
//    Console.WriteLine("Pelo menos um time do RJ tem título mundial");
//}

////Verifica se duas coleções não são iguais
//if (!timesSP.SetEquals(timesRJ))
//{
//    Console.WriteLine("\ntimesSP e timesRJ não contém os mesmos elementos");
//}


////////////////////////////////////////////////


//Console.WriteLine("\nJuntando os HashSet<T> : SP, RJ e BA");
//timesSP.UnionWith(timesRJ);
//timesSP.UnionWith(timesBA);

//ExibirColecao(timesSP);

//Console.WriteLine("\nJuntando os times de SP, RJ e BA ordenados");
//var todosTimes = new SortedSet<string>(timesSP);

//ExibirColecao(todosTimes);


////////////////////////////////////////////////


//junta os times em comum entre timesSP e timesMundiais
//Console.WriteLine("\nInterseção de dois HashSet<T> : timesAP e timesMundiais");
//timesSP.IntersectWith(timesMundiais);
//ExibirColecao(timesSP);


////////////////////////////////////////////////


//remove os times em comum entre timesSP e timesMundiais, mantem somente a diferença que existe no segundo (timesSP)
//Console.WriteLine("\nDiferença de dois HashSet<T> : timesMundiais e timesSP");
//timesMundiais.ExceptWith(timesSP);
//ExibirColecao(timesMundiais);


////////////////////////////////////////////////


//remove os times em comum entre timesSP e timesMundiais, mantem somente a diferença que existe nos dois
//Console.WriteLine("\nDiferença de dois HashSet<T> : timesMundiais e timesSP com SymmetricExceptWith");
//timesMundiais.SymmetricExceptWith(timesSP);
//ExibirColecao(timesMundiais);


////////////////////////////////////////////////


Console.WriteLine("\nRemove todos os elementos de timesMundiais");
timesMundiais.Clear();
ExibirColecao(timesMundiais);
Console.WriteLine("Fim do processamento...");

Console.ReadKey();

static void ExibirColecao<T>(IEnumerable<T> colecao)
{
    Console.WriteLine();
    foreach (var item in colecao)
    {
        Console.WriteLine($"{item}");
    }
}