using EnviaTrocas.Model;
using Microsoft.EntityFrameworkCore;

namespace EnviaTrocas.Data
{
    public class DataContext : DbContext
    {
        public DataContext() { }

        public DbSet<Provider> Provider { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Register> Register { get; set; }
        public DbSet<RegisterItens> RegisterItens { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseMySql("Host=192.168.0.60;Database=DbErpMega;Username=mega;Password=mega@3212");
            //optionsBuilder.UseMySql("Host=192.168.0.19;Database=DbErpMega;Username=mega;Password=mega@3212");
            optionsBuilder.UseMySql("Host=localhost;Database=DbErpMega;Username=root;Password=3103");
        }
    }
}
