using Contexto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace CrudUsuarios.Data
{
    public class SampleContextFactory: IDesignTimeDbContextFactory<ServiceContext>
    {
        public ServiceContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration =new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var builder = new DbContextOptionsBuilder<ServiceContext>();
            var connectionString = configuration.GetConnectionString("ConnectionDatabase");
            builder.UseSqlServer(connectionString,b =>b.MigrationsAssembly("CrudUsuarios"));
            return new ServiceContext(builder.Options);
        }
    }
}
