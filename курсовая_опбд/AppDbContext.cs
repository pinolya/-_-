using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace курсовая_опбд
{
    public class AppDbContext : DbContext
    {
        private const string ConnectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=RestrauntDb;Integrated Security=True;";

        public DbSet<Appendix> Appendices { get; set; }
        public DbSet<Compozitions> Compozitions { get; set; }
        public DbSet<Menus> Menus { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Razdels> Razdels { get; set; }
        public DbSet<Sotrudnik> Sotrudniks { get; set; }
        public DbSet<Table> Tables { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Menus>()
                .HasMany(u => u.Compozitions)
                .WithOne(b => b.Menus)
                .HasForeignKey(b => b.DishId);
            modelBuilder.Entity<Razdels>()
                .HasMany(u => u.Menus)
                .WithOne(b => b.Razdels)
                .HasForeignKey(b => b.IdRazdel);
            modelBuilder.Entity<Order>()
                .HasOne(u => u.Menus)
                .WithMany(b => b.Orders)
                .HasForeignKey(b => b.DishId);
            modelBuilder.Entity<Appendix>()
                .HasOne(u => u.Order)
                .WithOne(b => b.Appendix)
                .HasForeignKey<Appendix>(b => b.OrderId);
            modelBuilder.Entity<Table>()
                .HasOne(u => u.Appendix)
                .WithOne(b => b.Table)
                .HasForeignKey<Appendix>(b => b.TableId);
            modelBuilder.Entity<Table>()
                .HasOne(u => u.User)
                .WithOne(b => b.Table)
                .HasForeignKey<Table>(b => b.UserId);
            modelBuilder.Entity<Sotrudnik>()
                .HasMany(u => u.Appendix)
                .WithOne(b => b.Sotrudnik)
                .HasForeignKey(b => b.StaffId);
        }
    }
}
