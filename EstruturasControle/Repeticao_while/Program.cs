Console.WriteLine("## Instrução While ##\n");

//var i = 10;

//while (i > 0)
//{
//    Console.WriteLine($"i= {i}");
//    i--;
//}

//////////////////////////////////////////

//int numero;
//int contador = 1;

//Console.WriteLine("\nDigite um número maior que zero\t");
//numero = Convert.ToInt32(Console.ReadLine());

//if (numero > 0)
//{
//    Console.WriteLine($"\n## Tabuada do {numero} ##\n");
//    while (contador < 11)
//    {
//        Console.WriteLine($"{numero} x {contador} = {numero * contador}");
//        contador++;
//    }
//}
//else
//{
//    Console.WriteLine("\nNúmero deve ser maior que zero!!");
//}

//////////////////////////////////////////

//while (true)
//{
//    Console.WriteLine("\nInforme um número inteiro: (para sair tecle 999)");

//    int numero = Convert.ToInt32(Console.ReadLine());

//    if (numero == 999)
//    {
//        break;
//    }

//    if (numero % 2 == 0)
//    {
//        Console.WriteLine($"{numero} é PAR");
//    }
//    else
//    {
//        Console.WriteLine($"{numero} é ÍMPAR");
//    }
//}

//////////////////////////////////////////

//int x = 0;
//while (x < 5)
//{
//    int y = 0;
//    while (y < 5)
//    {
//        Console.Write($"({x},{y}) ");
//        y++;
//    }
//    x++;
//    Console.WriteLine();
//}

//////////////////////////////////////////

var i = 1;

do
{
    Console.WriteLine($"i = {i}");
    i++;

    if (i > 7)
    {
        break;
    }

} while (i <= 10);

Console.WriteLine("\nFim do processamento...");
Console.ReadKey();
