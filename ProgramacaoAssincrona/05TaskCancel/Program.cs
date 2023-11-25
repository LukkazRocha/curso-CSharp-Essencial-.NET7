using System.Diagnostics;

namespace _05TaskCancel
{
    internal class Program
    {        
        static async Task Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            try
            {
                //cancellationTokenSource = new CancellationTokenSource();
                //cancellationTokenSource.Cancel();

                //Console.WriteLine("Cancelamento automático após 1,5 segundos");
                //await ExecutaCancelamentoComTimeout(3000);

                Console.WriteLine("Cancelamento manuel");
                await ExecutaCancelamentoManual();

                //Console.WriteLine(resultado);
            }
            catch (Exception)
            {

                Console.WriteLine("Tarefa cancelada: " +
                    $"tempo expirado após {stopwatch.Elapsed}.\n");
            }

            Console.ReadKey();
        }

        public static async Task ExecutaCancelamentoManual()
        {
            using (var cancellationTokenSource = new CancellationTokenSource())
            {
                var tecladoTask = Task.Run(() =>
                {
                    Console.WriteLine("Pressione algo para cancelar...");
                    Console.ReadKey();
                    cancellationTokenSource.Cancel();
                });
                try
                {
                    var tarefa = OperacaoLongaDuracaoCancelavel(500, cancellationTokenSource.Token);
                    var resultado = await tarefa;
                    Console.WriteLine($"Resultado {resultado}");
                }
                catch (TaskCanceledException)
                {

                    throw;
                }
                await tecladoTask;
            }
        }

        private static async Task ExecutaCancelamentoComTimeout(int tempo)
        {
            using (var cancellationTokenSource = new CancellationTokenSource())
            {
                cancellationTokenSource.CancelAfter(tempo);
                try
                {
                    var resultado = await OperacaoLongaDuracaoCancelavel(100, cancellationTokenSource.Token);

                    Console.WriteLine($"Resultado {resultado}");
                }
                catch (TaskCanceledException)
                {

                    throw;
                }
            }
        }

        private static Task<int> OperacaoLongaDuracaoCancelavel(int valor,
        CancellationToken cancellationToken = default)
        {
            Console.WriteLine("Executou Operação de longa duração");

            Task<int> task = null;

            task = Task.Run(() =>
            {
                int resultado = 0;
                for (int i = 0; i < valor; i++)
                {
                    if (cancellationToken.IsCancellationRequested)
                        throw new TaskCanceledException(task);

                    Thread.Sleep(50);
                    resultado += i;
                }
                return resultado;
            });
            return task;
        }
    }
}