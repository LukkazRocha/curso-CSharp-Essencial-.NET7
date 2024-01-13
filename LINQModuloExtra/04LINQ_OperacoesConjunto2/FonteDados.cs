namespace _04LINQ_OperacoesConjunto2
{
    public class FonteDados
    {
        public static List<Aluno> GetTurmaA()
        {
            return new List<Aluno>()
            {
                new() {Nome = "Maria", Idade = 36, Nascimento = new DateTime(2001, 6, 11)},
                new() {Nome = "Manoel", Idade = 33, Nascimento = new DateTime(2000, 2, 10)},
                new() {Nome = "Amanda", Idade = 21, Nascimento = new DateTime(1986, 9, 30)},
                new() {Nome = "Carlos", Idade = 18, Nascimento = new DateTime(1999, 10, 11)},
                new() {Nome = "Jaime", Idade = 36, Nascimento = new DateTime(1988, 9, 15)},
            };
        }

        public static List<Aluno> GetTurmaB()
        {
            return new List<Aluno>()
            {
                new() {Nome = "Homero", Idade = 26, Nascimento = new DateTime(1988, 9, 15)},
                new() {Nome = "Maria", Idade = 31, Nascimento = new DateTime(2001, 9, 30)},
                new() {Nome = "Felicio", Idade = 21, Nascimento = new DateTime(1986, 9, 30)},
                new() {Nome = "Carlos", Idade = 18, Nascimento = new DateTime(2002, 8, 15)},
                new() {Nome = "Alfredo", Idade = 33, Nascimento = new DateTime(1999, 10, 11)},
                new() {Nome = "Manoel", Idade = 30, Nascimento = new DateTime(2004, 11, 5)},
            };
        }
    }
}