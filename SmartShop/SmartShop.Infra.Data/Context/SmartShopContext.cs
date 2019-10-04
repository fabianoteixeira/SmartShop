using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using SmartShop.Domain.Entities;
using SmartShop.Infra.Data.Mapping;

namespace SmartShop.Infra.Data.Context
{
    public class SmartShopContext: DbContext
    {
        private readonly IHostingEnvironment _env;

        public SmartShopContext(IHostingEnvironment env)
        {
            _env = env;
        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            

            modelBuilder.ApplyConfiguration(new MappingCategory());

            base.OnModelCreating(modelBuilder);
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // get the configuration from the app settings
            var config = new ConfigurationBuilder()
                .SetBasePath(_env.ContentRootPath)
                .AddJsonFile("appsettings.json")
                .Build();

            // define the database to use
            optionsBuilder.UseSqlServer(config.GetConnectionString("School"));
        }
    }
}
