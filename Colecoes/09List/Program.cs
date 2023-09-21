Console.WriteLine("## List ##\n");

////declarar uma coleção do tipo List<T>

//List<string> lista;
//lista = new List<string>();

//List<int> lista1 = new List<int>();
//var lista2 = new List<float>();
//List<double> lista3 = new();

//List<string> nomes = new();
//nomes.Add("Paulo");
//nomes.Add("Maria");

//var lista4 = new List<string>()
//{
//    "Paulo", "Maria", "Bia", "Pedro"
//};


///////////////////////////////////////


//var lista = new List<string>() { "Maria", "Ana", "Pedro", "Carlos", "Zé" };

//lista.Add("Marta");

//lista.Insert(2, "Bia");

//Console.WriteLine(lista.Count + " itens ");


//////////////////////////////////////


var lista = new List<string>() { "Maria", "Pedro", "Ana" };

string[] array1 = new string[] { "Diná", "Carlos", "Pedro" };

lista.AddRange(array1);

lista.InsertRange(1, array1);

Console.WriteLine(lista.Count + " itens ");

Console.ReadKey();