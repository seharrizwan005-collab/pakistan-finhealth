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
    }
}