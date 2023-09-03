Console.WriteLine("## Estrutura switch-case ##\n");

//int compra = 600;
//Console.WriteLine("Valor da compra R$ 600,00");
//Console.WriteLine("Informe o no. de parcelas (1 a 3)");
//var numeroParcelas = Convert.ToInt32(Console.ReadLine());

//switch (numeroParcelas)
//{
//    case 1:
//        Console.WriteLine($"\n Prestação R$ {compra / numeroParcelas}");
//        break;
//    case 2:
//        Console.WriteLine($"\n Prestação R$ {compra / numeroParcelas}");
//        break;
//    case 3:
//        Console.WriteLine($"\n Prestação R$ {compra / numeroParcelas}");
//        break;
//    default:
//        Console.WriteLine("Valor inválido, informe 1, 2 ou 3");
//        break;
//}

///////////////////////////////////////////////////////////////////////////

//Console.WriteLine("Informe o numero inteiro");
//var numero = Convert.ToInt32(Console.ReadLine());

//switch (numero % 2)
//{
//    case 0:
//        Console.WriteLine($"O número {numero} é par");
//        break;
//    case 1:
//        Console.WriteLine($"O número {numero} é ímpar");
//        break;
//}

///////////////////////////////////////////////////////////////////////////

//Console.WriteLine("Informe o nome do mês\t");
//var mes = Console.ReadLine().ToLower();

//switch (mes)
//{
//    case "janeiro":
//    case "março":
//    case "maio":
//    case "julho":
//    case "agosto":
//    case "outubro":
//    case "dezembro":
//        Console.WriteLine("Este mês tem 31 dias");
//        break;
//    case "fevereiro":
//        Console.WriteLine("Este mês tem 28 ou 29 dias");
//        break;
//    default:
//        Console.WriteLine("Esse mês tem 30 dias");
//        break;
//}

///////////////////////////////////////////////////////////////////////////

int cargo = 0;
int funcao = 0;

Console.WriteLine("Você é Gerente(1) ou Programador(2)\t");
cargo = Convert.ToInt32(Console.ReadLine());

if (cargo == 2)
{
    Console.WriteLine("Você é Junior(1) ou Senior(2)");
    funcao = Convert.ToInt32(Console.ReadLine());
}

switch (cargo)
{
    case 1:
        Console.WriteLine("\nBem vindo Gerente");
        break;
    case 2:
        Console.WriteLine("\nBem vindo Programador");
        switch (funcao)
        {
            case 1:
                Console.WriteLine("\nVocê é Junior");
                break;
            case 2:
                Console.WriteLine("\nVocê é Senior");
                break;
            default:
                Console.WriteLine("\nFunção desconhecida");
                break;
        }
        break;
    default:
        Console.WriteLine("Não consigo te identificar");
        break;
}

Console.WriteLine("\nFim de processamento...");

Console.ReadKey();
