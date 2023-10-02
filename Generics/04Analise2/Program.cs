using System.Collections;

//Análise de Desempenho

ArrayList obj = new ArrayList();

//boxing - converter o tipo por valor e para tipo referência
obj.Add(50);

int x = (int)obj[0]; // realiza unboxinh

foreach (int i in obj)
{
    Console.WriteLine(i); // realiza unboxing
}