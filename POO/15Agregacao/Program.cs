
using _15Agregacao;

Professor prof1 = new("Carlos", "Química");
Professor prof2 = new("Maria", "Inglês");
Professor prof3 = new("Ana", "Literatura");
Professor prof4 = new("Paulo", "Matemática");

Departamento dep1 = new("Exatas");
dep1.IncluirProfessor(prof1);
dep1.IncluirProfessor(prof4);
dep1.ListaProfessores();

Departamento dep2 = new("Humanas");
dep2.IncluirProfessor(prof2);
dep2.IncluirProfessor(prof3);
dep2.ListaProfessores();

Console.ReadKey();
