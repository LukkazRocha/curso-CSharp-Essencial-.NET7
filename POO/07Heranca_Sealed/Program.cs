Console.WriteLine("## Herança Sealed ##\n");

//Cliente cli = new();
////cli.Nome = "José";
//cli.ExibeNome();


/////////////////////////////////




Console.ReadKey();

//sealed class Pessoa
//{
//    public string? Nome { get; set; }
//    public void ExibeNome()
//    {
//        Console.WriteLine($"Meu nome é {Nome}");
//    }
//}

//class Cliente
//{
//    public new void ExibeNome()
//    {
//        //Console.WriteLine($"\nNome do cliente: {Nome}");
//    }
//}


/////////////////////////////////


class ClasseBase
{
    protected virtual void Metodo1()
    {
        Console.WriteLine("ClasseBase.Metodo1()");
    }
    protected virtual void Metodo2()
    {
        Console.WriteLine("ClasseBase.Metodo2()");
    }
}

class Classe1 : ClasseBase
{
    sealed protected override void Metodo1()
    {
        Console.WriteLine("Classe1.Metodo1");
    }
    protected override void Metodo2()
    {
        Console.WriteLine("Classe1.Metodo2");
    }
}

class Classe2 : Classe1
{
    protected override void Metodo1()
    {
        Console.WriteLine("Classe2.Metodo1");
    }
    protected override void Metodo2()
    {
        Console.WriteLine("Classe2.Metodo2");
    }
}