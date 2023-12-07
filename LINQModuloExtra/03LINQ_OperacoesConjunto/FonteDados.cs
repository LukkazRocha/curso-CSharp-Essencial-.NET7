namespace _03LINQ_OperacoesConjunto
{
    public class FonteDados
    {
        public static int[] GetIdades()
        {
            return new int[]
            {
                30, 33, 35, 36, 40, 30, 33, 36, 30, 40
            };
        }

        public static string[] GetNomes()
        {
            return new string[]
            {
                "Paulo", "MARIA", "paulo", "Amanda", "maria", "amanda"
            };
        }

        public static List<Aluno> GetAlunos()
        {
            return new List<Aluno>
            {
                new() { Nome = "Maria", Idade = 36 },
                new() { Nome = "Manoel", Idade = 33 },
                new() { Nome = "Amanda", Idade = 21 },
                new() { Nome = "Carlos", Idade = 18 },
                new() { Nome = "Jaime", Idade = 36 },
                new() { Nome = "Debora", Idade = 33 },
                new() { Nome = "Alicia", Idade = 18 },
                new() { Nome = "Sandra", Idade = 19 }
            };
        }
    }
}