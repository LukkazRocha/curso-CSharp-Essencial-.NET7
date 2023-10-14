Console.WriteLine("## Criando o SortedDictionary ##\n");

var brics = new SortedDictionary<int, string>()
{
    { 20, "Brasil" },
    { 10, "China" },
    { 40, "India" },
    { 30, "URSS" },
};

Console.WriteLine("\nIncluindo o elemento de chave=70 e valor =África do Sul");
if(brics.ContainsKey(70))
{
    Console.WriteLine("Chave já existe");
}
else
{
    brics.Add(70, "África do Sul");
}

Console.WriteLine($"Número de pares de chaves(elemento) no dicionário : {brics.Count}");

Console.WriteLine("\n-Acessando um elemento pela chave -> brics[20]");
Console.WriteLine($"Chave 20 -> {brics[20]}");

Console.WriteLine("\n-Alterando o valor da chave 20 para Argentina -> brics[20] = Argentina");
brics[20] = "Argentina";
Console.WriteLine($"Chave 20 -> {brics[20]}");

Console.WriteLine("\n-Removendo a chave 10 : brics.Remove[10] -> China");
brics.Remove(10);

Console.WriteLine("\n-Verificando se uma chave existe com ContainsKey");
Console.WriteLine($"Existe a chave : 30 ? -> {brics.ContainsKey(30)}");

Console.WriteLine("\nVerificando se um valor existe com ContainsValue");
Console.WriteLine($"Exite o valor : 'URSS' -> {brics.ContainsValue("URSS")}");
Console.WriteLine($"Exite o valor : 'Chile' -> {brics.ContainsValue("Chile")}");

Console.WriteLine("\n-Obtendo o valor da chave 30 usando o TryGetValue");

if (brics.TryGetValue(30, out string? valor))
{
    Console.WriteLine($"Valor da chave 30 : {valor}");
}
else
{
    Console.WriteLine("A chave não existe.");
}

Console.WriteLine("\nPercorrendo um SortedDictionary com foreach\n");
foreach (var pais in brics)
{
    Console.WriteLine($"Chave/Valor = {pais.Key} {pais.Value}");
}

Console.ReadKey();