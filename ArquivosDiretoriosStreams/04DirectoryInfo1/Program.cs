
var caminhoDiretorio = @"c:\workspace\dados";

var dirOrigem = new DirectoryInfo(caminhoDiretorio);

Console.WriteLine("Nome do diretório: " + dirOrigem.Name);
Console.WriteLine("Caminho completo do diretório: " + dirOrigem.FullName);
Console.WriteLine("Data da criação: " + dirOrigem.CreationTime);
Console.WriteLine("Último acesso: " + dirOrigem.LastAccessTime);
Console.WriteLine("Última modificação: " + dirOrigem.LastWriteTime);
Console.WriteLine("Atributos: " + dirOrigem.Attributes);

Console.WriteLine("\nCriando um novo diretório");
var novoDiretorio = new DirectoryInfo(@"c:\workspace\dados\MeuDiretorio");

try
{
    if (!novoDiretorio.Exists)
    {
        novoDiretorio.Create();
        Console.WriteLine($"{novoDiretorio} criando com sucesso!");
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

try
{
    if (novoDiretorio.Exists)
    {
        novoDiretorio.Delete();
        Console.WriteLine($"{novoDiretorio} excluído com sucesso!");
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.WriteLine($"Exibindo os subdiretórios de {caminhoDiretorio}");
try
{
    foreach (var subdir in dirOrigem.GetDirectories())
    {
        Console.WriteLine(subdir.Name);
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.WriteLine($"Exibindo os arquivos de {caminhoDiretorio}");
try
{
    foreach (var arquivo in dirOrigem.GetFiles())
    {
        Console.WriteLine(arquivo.Name);
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.WriteLine($"\nCriar um subdiretório em {caminhoDiretorio}");
try
{
    dirOrigem.CreateSubdirectory("NovoSubdiretorio");
    Console.WriteLine("Subdiretório criando com sucesso!");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.ReadKey();
