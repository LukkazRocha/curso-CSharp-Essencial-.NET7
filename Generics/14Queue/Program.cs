﻿
//Queue<string> diasSemana = new Queue<string>();
//diasSemana.Enqueue("Segunda");
//diasSemana.Enqueue("Terça");

//int[] array1 = new int[] { 1, 2, 3, 4, 5 };
//var numeros = new Queue<int>(array1);

//var impares = new Queue<int>(3);
//impares.Enqueue(1);


////////////////////////////////////////////


string[] cursos = new string[] { "C#", "Python", "Java", "SQL", "Asp.Net" };
Queue<string> fila1 = new Queue<string>(cursos);

Console.WriteLine("No. de elementos na fila1 : " + fila1.Count);

ExibirFila(fila1);

fila1.Enqueue(".NET MAUI");
ExibirFila(fila1);

Console.WriteLine("\n-Obtém o primeiro item da fila com Peek");
var elemento = fila1.Peek();
Console.WriteLine(elemento);

Console.WriteLine("\n-Método Dequeue - remove ítem do início da fila");
fila1.Dequeue();
ExibirFila(fila1);

if (fila1.Contains("C#"))
{
    Console.WriteLine("\nC# está na fila");
}
else
{
    Console.WriteLine("\nC# NÃO está na fila");
}

Console.WriteLine("\n-Limpa a fila com Clear()");
fila1.Clear();
Console.WriteLine("No. de elementos na fila1 : " + fila1.Count);

Console.ReadKey();

static void ExibirFila<T>(IEnumerable<T> fila1)
{
    Console.WriteLine();
    foreach (var item in fila1)
    {
        Console.WriteLine(item);
    }
}