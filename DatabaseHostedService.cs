
using Microsoft.EntityFrameworkCore;
using ProyectoDAM_ABF2023.Data;

namespace ProyectoDAM_ABF2023
{
    public class DatabaseHostedService : IHostedService
    {
        private IServiceScopeFactory _scopeFactory;

        public DatabaseHostedService(IServiceScopeFactory scopeFactory) {
            _scopeFactory = scopeFactory;
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            using var scope = _scopeFactory.CreateScope();
            var dataContext = scope.ServiceProvider.GetRequiredService<DataContext>();
            await dataContext.Database.MigrateAsync();
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
