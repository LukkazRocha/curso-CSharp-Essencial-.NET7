
string caminhoOrigem = @"c:\workspace\dados\arquivo1.txt";
string caminhoDestino = @"c:\workspace\dados\txt\arquivo1.txt";

//criar arquivo
//File.Create(caminhoOrigem);
if (!File.Exists(caminhoDestino))
{
    try
    {
        File.WriteAllText(caminhoOrigem, "Fernando Pessoa \r\n");

        string novoTexto = "O poeta é um fingidor " +
                            Environment.NewLine +
                            "Finge tão completamente \r\n" +
                            "Que chega a fingir que é dor \r\n" +
                            "A dor que deveras sente. \r\n";

        File.AppendAllText(caminhoOrigem, novoTexto);

        //lê o conteúdo do arquivo
        Console.WriteLine("\nConteúdo e informações do arquivo:");
        string conteudo = File.ReadAllText(caminhoOrigem);
        Console.WriteLine(conteudo);

        Console.WriteLine($"Última modificação feita em: {File.GetLastWriteTimeUtc(caminhoOrigem)}");
        Console.WriteLine($"Último acesso feito em: {File.GetLastAccessTimeUtc(caminhoOrigem)}");
        string[] linhas = File.ReadAllLines(caminhoOrigem);
        foreach (var linha in linhas)
        {
            Console.WriteLine(linha);
        }

        var caminhoCopia = @"c:\workspace\dados\arquivo1_copia.txt";
        Console.WriteLine($"Copiando de {caminhoOrigem} para {caminhoCopia}");
        File.Copy(caminhoOrigem, caminhoCopia);

        Console.WriteLine($"\nMovendo {caminhoOrigem} para {caminhoDestino}");
        File.Move(caminhoOrigem, caminhoDestino);

        //excluir
        Console.WriteLine($"Excluindo {caminhoOrigem}, {caminhoDestino} e {caminhoCopia}");
        File.Delete(caminhoOrigem);
        //File.Delete(caminhoDestino);
        File.Delete(caminhoCopia);
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}
Console.WriteLine("Concluído");

Console.ReadKey();