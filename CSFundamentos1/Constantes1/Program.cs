Console.WriteLine("## Constantes ##\n");

//Cálculo da área e perímetro do circulo

double raio, perimetro, area;

const double PI = 3.14;

Console.WriteLine("Informe o raio do círculo");
raio = Convert.ToDouble(Console.ReadLine());

perimetro = 2 * PI * raio;
area = PI * raio * raio;

Console.WriteLine($"Perímetro = {perimetro}");
Console.WriteLine($"Area = {area}");

Console.ReadKey();
