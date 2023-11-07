using _12LINQConsultas2;
using System;

//fonte dados
var listaProdutos = Produto.GetProdutos();

Console.WriteLine("\n-First - Localiza o primeiro elemento");
var primeiroProduto = listaProdutos.First();
Console.WriteLine($"{primeiroProduto.Nome} \t{primeiroProduto.Preco:C2}");

Console.WriteLine("\n-First - Localiza o primeiro elemento usando um critério de nome");
try
{
    var primeiraOcorrencia1 = listaProdutos.First(p => p.Nome == "Cadeira");
    Console.WriteLine($"{primeiraOcorrencia1.Nome} \t{primeiraOcorrencia1.Preco:C2}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.WriteLine("\n-FirstOrDefault - Localiza o primeiro elemento usando um critério de nome");
var primeiraOcorrencia2 = listaProdutos.FirstOrDefault(p => p.Nome == "Cadeira");
if (primeiraOcorrencia2 != null)
{
    Console.WriteLine($"{primeiraOcorrencia2.Nome} \t{primeiraOcorrencia2.Preco:C2}");
}
else
{
    Console.WriteLine("## Nenhum elemento foi encontrado segundo o critério ##");
}

Console.WriteLine("\n-Last - Localiza o último elemento");
var ultimoProduto = listaProdutos.Last();
Console.WriteLine($"{ultimoProduto.Nome} \t{ultimoProduto.Preco:C2}");

Console.WriteLine("\n-Last - Localiza o último elemento usando um critério de nome");
try
{
    var ultimaOcorrencia1 = listaProdutos.Last(p => p.Nome == "Cadeira");
    Console.WriteLine($"{ultimaOcorrencia1.Nome} \t{ultimaOcorrencia1.Preco:C2}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.ReadKey();
