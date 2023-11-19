string caminho = "c:\\workspace\\txt\\poesia.txt";

char dirSeparador = Path.DirectorySeparatorChar;
Console.WriteLine("O separador de diretório padrão é: " + dirSeparador);

string[] diretorios = caminho.Split(dirSeparador);

Console.WriteLine("Os diretórios e arquivos no caminho são:");
foreach (var dir in diretorios)
{
    Console.WriteLine(dir);
}

Console.ReadKey();
