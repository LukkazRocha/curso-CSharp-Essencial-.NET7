Console.WriteLine("## Nullable Types ##\n");

//int? i = null;
//double? d = null;
//bool? b = null;

//Console.WriteLine(i);
//Console.WriteLine(d);
//Console.WriteLine(b);

#region Erro de execução

//Esses trechos darão erro pois não é possível converter um int? para int

//int? a = null;
//int b = a;

//int? x = 4;
//int y = 3;
//int z = x * y;
//Console.WriteLine(z);

#endregion

int? b = 100;
if (b.HasValue)
{
    Console.WriteLine($"b = {b.Value}");
}
else
{
    Console.WriteLine("b não possui valor");
}

Console.ReadKey();
