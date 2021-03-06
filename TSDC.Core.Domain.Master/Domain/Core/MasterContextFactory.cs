using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace TSDC.Core.Domain.Master
{
    public class MasterContextFactory : IDesignTimeDbContextFactory<MasterContext>
    {
        public MasterContext CreateDbContext(string[] args)
        {
            var dbContextBuilder = new DbContextOptionsBuilder();

            IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();
            dbContextBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));

            return new MasterContext(dbContextBuilder.Options);
        }
    }
}
