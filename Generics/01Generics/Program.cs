Teste<int, int> teste = new Teste<int, int>();
Teste<float, float> teste2 = new Teste<float, float>();
//Teste<string, string> teste3 = new Teste<string, string>();

int i1 = 10;
int i2 = 10;

float f1 = 10f;
float f2 = 10f;

string s1 = "10";
string s2 = "10";

teste.Comparar(i1, i2);
teste2.Comparar(f1, f2);
//teste3.Comparar(s1, s2);

Console.ReadKey();

public class Teste<T1, T2> where T1 : struct where T2 : struct
{
    public void Comparar<T1, T2>(T1 p1, T2 p2)
    {
        Console.WriteLine($"Os tipos: {p1.GetType()} e {p2.GetType()}\n");
        var resultado = p1.Equals(p2);
        Console.WriteLine($" {p1} e {p2} são iguais? {resultado}\n");
    }
}