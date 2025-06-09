#region Usings
using Microsoft.EntityFrameworkCore;
using Template.Data.Users;
#endregion

namespace Template.Data
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
