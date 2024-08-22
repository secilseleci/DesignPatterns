using Microsoft.EntityFrameworkCore;

namespace DesignPattern.Mediator.DAL
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=SECIL-ASUS\\SQLEXPRESS; initial catalog=Mediator;integrated security=true;");
        }
       
        public DbSet<Product> Products { get; set; }
    }
}
