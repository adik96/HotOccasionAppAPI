using HotOccasionApp.DB.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HotOccasionApp.DB
{
    public class AppDBContext : IdentityDbContext<User>
    {
        //public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Occasion> Occasions { get; set; }
        public virtual DbSet<OcassionPrices> OcassionsPrices { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<KeyWord> KeyWords { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }


        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }

        public static AppDBContext Create(DbContextOptions<AppDBContext> options)
        {
            return new AppDBContext(options);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().ToTable("Users");

            modelBuilder.Entity<Occasion>().ToTable("Occasions");
            modelBuilder.Entity<Occasion>().Property(i => i.Id).ValueGeneratedOnAdd();

            modelBuilder.Entity<OcassionPrices>().ToTable("OcassionsPrices");
            modelBuilder.Entity<OcassionPrices>().Property(i => i.Id).ValueGeneratedOnAdd();

            modelBuilder.Entity<Category>().ToTable("Categories");
            modelBuilder.Entity<Category>().Property(i => i.Id).ValueGeneratedOnAdd();

            modelBuilder.Entity<KeyWord>().ToTable("KeyWords");
            modelBuilder.Entity<KeyWord>().Property(i => i.Id).ValueGeneratedOnAdd();

            modelBuilder.Entity<Comment>().ToTable("Comments");
            modelBuilder.Entity<Comment>().Property(i => i.Id).ValueGeneratedOnAdd();

            modelBuilder.Entity<OccasionCategory>()
            .HasKey(x => new { x.OccasionId, x.CategoryId });

            modelBuilder.Entity<OccasionCategory>()
            .HasOne(pt => pt.Occasion)
            .WithMany(p => p.Categories)
            .HasForeignKey(pt => pt.OccasionId);

            modelBuilder.Entity<OccasionCategory>()
            .HasOne(pt => pt.Category)
            .WithMany(t => t.Occasions)
            .HasForeignKey(pt => pt.CategoryId);
        }
    }
}