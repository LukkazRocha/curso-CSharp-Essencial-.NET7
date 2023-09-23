namespace _11Exercicio
{
    public class Aluno
    {
        public Aluno(string nome, double nota)
        {
            Nome = nome;
            Nota = nota;
        }

        public string Nome { get; set; }

        public double Nota { get; set; }        
    }
}
