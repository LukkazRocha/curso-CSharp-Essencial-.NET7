namespace _02LINQProjecao
{
    public class FonteDados
    {
        public static List<Aluno> GetAlunos()
        {
            return new()
            {
                new() { Nome = "Maria", Idade = 22, Nota = 7, Cursos = new List<string> { "VB.NET", "ASP.NET" } },
                new() { Nome = "Manoel", Idade = 24, Nota = 6, Cursos = new List<string> { "C#", "EF Core" } },
                new() { Nome = "Amanda", Idade = 21, Nota = 5, Cursos = new List<string> { "Java", "Node" } },
                new() { Nome = "Carlos", Idade = 18, Nota = 9, Cursos = new List<string> { "C++", "MongoDB", "Node" } },
                new() { Nome = "Alicia", Idade = 17, Nota = 4, Cursos = new List<string> { "TypeScript", "React", "Node" } },
            };
        }

        public static List<Funcionario> GetFuncionarios()
        {
            return new()
            {
                new() { Nome = "Maria", Idade = 22, Salario = 3290.55m },
                new() { Nome = "Manoel", Idade = 24, Salario = 4125.45m },
                new() { Nome = "Amanda", Idade = 21, Salario = 5123.99m},
                new() { Nome = "Carlos", Idade = 18, Salario = 6200.50m },
                new() { Nome = "Alicia", Idade = 17, Salario = 4099.11m },
            };
        }
    }
}