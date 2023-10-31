Console.WriteLine("Informe um número inteiro:");
int numero = Convert.ToInt32(Console.ReadLine());

//DelegatePar delegatePar = VerificaPar;

//Predicate<int> delegatePar = VerificaPar;

//Predicate<int> delegatePar = delegate (int x)
//{
//    return x % 2 == 0;
//};

Predicate<int> delegatePar = x => x % 2 == 0;

if (delegatePar(numero))
{
    Console.WriteLine($"O número {numero} é PAR");
}
else
{
    Console.WriteLine($"O número {numero} é ÍMPAR");
}

Console.ReadKey();

static bool VerificaPar(int x)
{
    if (x % 2 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

public delegate bool DelegatePar(int numero);
