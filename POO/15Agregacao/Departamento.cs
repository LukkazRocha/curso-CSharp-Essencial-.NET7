namespace _15Agregacao
{
    internal class Departamento
    {
        public string? Nome { get; set; }

        private List<Professor>? Professores { get; set; }

        public Departamento(string? nome)
        {
            Nome = nome;
            Professores = new List<Professor>();
        }

        public void IncluirProfessor(Professor professor)
        {
            Professores?.Add(professor);
        }

        public void ListaProfessores()
        {
            Console.WriteLine($"\nDepartamento de: {Nome}\n");

            if (Professores?.Any() != null)
            {
                foreach (Professor prof in Professores)
                {
                    Console.WriteLine(prof.Nome + " -> " + prof.Disciplina);
                }
            }
        }

    }
}
