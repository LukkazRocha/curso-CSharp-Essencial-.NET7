Console.WriteLine("Informe um número inteiro:");
int numero = Convert.ToInt32(Console.ReadLine());

//Action<int> dobra = Duplicar;
//Action<int> dobra = delegate (int x)
//{
//    Console.WriteLine(x * 2);
//};
Action<int> dobra = x => Console.WriteLine(x * 2);

dobra(numero);

Console.ReadKey();

//static void Duplicar(int num)
//{
//    int resultado = num * 2;
//    Console.WriteLine(resultado);
//}