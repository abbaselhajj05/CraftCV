using CVCraft.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace CVCraft.Data {
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options) {
        public DbSet<CVInfo> CVInfos { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<CVInfo>().HasQueryFilter(c => !c.IsDeleted);
        }
    }
}
