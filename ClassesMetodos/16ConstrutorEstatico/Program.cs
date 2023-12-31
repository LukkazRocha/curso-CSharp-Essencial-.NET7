﻿Console.WriteLine("## Construtor estático ##\n");

//invoca o construtor parametrizado e o estático
Pessoa p1 = new(19, "Maria");

Console.WriteLine(p1.Nome + " - " + p1.Idade);
Console.WriteLine("Idade Mínima " + Pessoa.IdadeMinima);

//invoca somente o construtor parametrizado
Pessoa p2 = new(20, "Manoel");
Console.WriteLine(p2.Nome + " - " + p2.Idade);
Console.WriteLine("Idade Mínima " + Pessoa.IdadeMinima);

Console.ReadKey();
