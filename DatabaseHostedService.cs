
namespace ProyectoDAM_ABF2023
{
    public class DatabaseHostedService : IHostedService
    {
        public Task StartAsync(CancellationToken cancellationToken)
        {
            Console.Write("Meow");
            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
