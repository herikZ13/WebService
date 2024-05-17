using Microsoft.EntityFrameworkCore;
using WebService.Models;

namespace WebService.DataAccess
{
    public class MySQLContext : DbContext

    {

        public DbSet<Catalumnocs> Catalumnocs { get; set; }
        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options)
        {

        }
        public override int SaveChanges()
        {
            ChangeTracker.DetectChanges();
            return base.SaveChanges();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
