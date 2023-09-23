namespace _11List_Exercicio_Resolucao
{
    public static class FonteDados
    {
        public static List<Aluno> GetAlunos()
        {
            List<Aluno> alunos = new()
            {
                new () {Nome = "Maria", Nota = 8.75},
                new () {Nome = "Manoel", Nota = 6.95},
                new () {Nome = "Amanda", Nota = 7.25},
                new () {Nome = "Carlos", Nota = 6.55},
                new () {Nome = "Jaime", Nota = 8.50},
                new () {Nome = "Debora", Nota = 5.95},
                new () {Nome = "Alicia", Nota = 9.25},
                new () {Nome = "Sandra", Nota = 5.55},
                new () {Nome = "Marta", Nota = 7.85},
                new () {Nome = "Sueli", Nota = 9.15},
            };

            return alunos;
        }
    }
}
