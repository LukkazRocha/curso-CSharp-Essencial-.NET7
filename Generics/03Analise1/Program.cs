using System.Collections;

//Análise de Segurança de Tipagem

ArrayList lista = new ArrayList
{
    50,
    "Generics",
    new Aluno()
};

foreach (var obj in lista)
{
    Console.WriteLine(obj);
}

public class Aluno
{
    public string? Nome { get; set; }
}