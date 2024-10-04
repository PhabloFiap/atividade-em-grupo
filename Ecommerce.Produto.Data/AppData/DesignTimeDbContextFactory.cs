using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Ecommerce.Produto.Data.AppData
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ApplicationContext>
    {
        public ApplicationContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();

            // Carregar a configuração da connection string do appsettings.json
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory()) // Define o diretório base
                .AddJsonFile("appsettings.json") // Carrega o arquivo appsettings.json
                .Build();

            var connectionString = configuration.GetConnectionString("Oracle");

            optionsBuilder.UseOracle(connectionString);

            return new ApplicationContext(optionsBuilder.Options);
        }
    }
}
