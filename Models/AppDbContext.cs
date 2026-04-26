using Microsoft.EntityFrameworkCore;

namespace WebProject.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Bank> Banks { get; set; }
        public DbSet<RatioCategory> RatioCategories { get; set; }
        public DbSet<FinancialRatio> FinancialRatios { get; set; }
        public DbSet<AuditLog> AuditLogs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasKey(u => u.UserID);
            modelBuilder.Entity<Bank>().HasKey(b => b.BankID);
            modelBuilder.Entity<RatioCategory>().HasKey(r => r.CategoryID);
            modelBuilder.Entity<AuditLog>().HasKey(a => a.LogID);

            modelBuilder.Entity<FinancialRatio>().HasKey(f => f.RatioID);
            modelBuilder.Entity<FinancialRatio>()
                .HasOne(f => f.Bank)
                .WithMany()
                .HasForeignKey(f => f.BankID);
            modelBuilder.Entity<FinancialRatio>()
                .HasOne(f => f.RatioCategory)
                .WithMany()
                .HasForeignKey(f => f.CategoryID);
        }
    }
}