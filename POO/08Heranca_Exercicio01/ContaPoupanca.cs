namespace _08Heranca_Exercicio01
{
    public class ContaPoupanca : Conta
    {
        public override double Juros { get; set; } = 0.005;

        public override decimal Sacar(decimal valor)
        {
            if (Saldo >= valor)
            {
                Saldo -= valor;
                return Saldo;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente...");
                return Saldo;
            }
            
        }
    }
}
