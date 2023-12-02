namespace LINQMotivacao1
{
    public class FonteDados
    {
        public static List<int> GetNumeros()
        {
            return new List<int>
            {
                1, 2, 4, 8, 16, 32, 64, 128, 256, 512
            };
        }

        public static List<int> GetListaNegra()
        {
            return new List<int>
            {
                16, 128, 512
            };
        }

        public static List<Aluno> GetAlunos()
        {
            return new List<Aluno>
            {
                new() { Nome = "Maria", Idade = 42 },
                new() { Nome = "Manoel", Idade = 34 },
                new() { Nome = "Amanda", Idade = 21 },
                new() { Nome = "Carlos", Idade = 18 },
                new() { Nome = "Alicia", Idade = 15 },
            };
        }
    }
}