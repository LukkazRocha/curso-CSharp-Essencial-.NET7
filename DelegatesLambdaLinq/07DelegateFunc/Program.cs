Console.WriteLine("Digite um número:");
double numero = Convert.ToDouble(Console.ReadLine());

//Func<double, double> raizQuadrada = CalculaRaiz;
//Func<double, double> raizQuadrada = delegate (double x)
//{
//    return Math.Sqrt(x);
//};

Func<double, double> raizQuadrada = Math.Sqrt;

double resultado = raizQuadrada(numero);

Console.WriteLine($"\nA raiz quadrada de {numero} é {resultado}");

Console.ReadKey();

//static double CalculaRaiz(double numero)
//{
//    return Math.Sqrt(numero);
//}