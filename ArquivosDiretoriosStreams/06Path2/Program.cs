string path1 = "c:\\workspace\\dados";
string path2 = "txt\\poesia.txt";

string pathCombinado = Path.Combine(path1, path2);
Console.WriteLine("\nCaminho combinado: " + pathCombinado);

Console.WriteLine("\nNome do diretório: " + Path.GetDirectoryName(pathCombinado));
Console.WriteLine("\nExtensão: " + Path.GetExtension(pathCombinado));
Console.WriteLine("\nNome do arquivo: " + Path.GetFileName(pathCombinado));
Console.WriteLine("\nNome do arquivo sem extensão: " + Path.GetFileNameWithoutExtension(pathCombinado));
Console.WriteLine("\nPossui extensão?: " + Path.HasExtension(pathCombinado));
Console.WriteLine("\nContém a raiz?: " + Path.IsPathRooted(pathCombinado));
Console.WriteLine("\nNova extensão do arquivo: " + Path.ChangeExtension(pathCombinado, ".docx"));
Console.WriteLine("\nRaiz: " + Path.GetPathRoot(pathCombinado));
//
Console.WriteLine("\nNome do arquivo aleatório:" + Path.GetRandomFileName());
Console.WriteLine("\nNome do arquivo temporário:" + Path.GetTempFileName());
Console.WriteLine("\nCaminho temporário:" + Path.GetTempPath());

char[] caracteresInvalidosEmArquivos = Path.GetInvalidFileNameChars();
Console.WriteLine("\nCaracteres inválidos em nome de arquivos: " + new string(caracteresInvalidosEmArquivos));

Console.ReadKey();
