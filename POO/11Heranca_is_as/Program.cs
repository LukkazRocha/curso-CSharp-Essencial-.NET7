
//upcasting
//Object carroObj = new Carro();

//var x = carroObj as string;

//if (x != null)
//{
//    Console.WriteLine("converteu obj para string");
//}
//else
//{
//    Console.WriteLine("Não foi possível converter, x é null");
//}

//class Carro
//{

//}


////////////////////////////////////////


//downcasting
//using _11Heranca_is_as;

//Circulo circulo = new Circulo();
//Forma forma = circulo; //upcasting

////Circulo c = (Circulo)forma;
//Circulo c = forma as Circulo; // downcasting

//if (c != null)
//{
//    c.PintarCirculo();
//}
//else
//{
//    Console.WriteLine("Operação de downcasting é inválida");
//}


////////////////////////////////////////


using _11Heranca_is_as;

Circulo circulo = new Circulo();
Forma forma = circulo;

if (forma is Circulo) //verifica se o downcasting é possível
{
    Console.WriteLine("Converteu Forma para Círculo\n");

    //((Circulo)forma).PintarCirculo();
    var tipo = forma as Circulo;
    tipo?.PintarCirculo();
}
else
{
    Console.WriteLine("Operação de downcasting não é possível");
}

Console.ReadKey();