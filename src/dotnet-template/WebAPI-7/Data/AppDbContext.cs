#region Usings
using Microsoft.EntityFrameworkCore;
using WebAPI_7.Data.Users;
#endregion

namespace WebAPI_7.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        #region ColumnsRequirements
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
                .HasKey(i => new { i.Id });

            modelBuilder.Entity<User>()
                .HasIndex(i => new { i.PhoneNumber }).IsUnique();

            modelBuilder.Entity<User>()
                .HasIndex(i => new { i.Email }).IsUnique();
        }
        #endregion

        #region Tables
        public DbSet<User> Users { get; set; }
        #endregion
    }
}
