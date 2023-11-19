

var caminhoDiretorio = @"c:\workspace\dados\MeuDiretorio";
var caminhoDestino = @"c:\workspace\dados\MeuDiretorioNovo";

Console.WriteLine("\nRenomeando um diretório");

try
{
    if (Directory.Exists(caminhoDiretorio))
    {
        Directory.Move(caminhoDiretorio, caminhoDestino);
        Console.WriteLine("Diretório renomeado com sucesso!");
    }
    else
    {
        Console.WriteLine($"O diretório {caminhoDiretorio} não existe!");
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.ReadKey();
