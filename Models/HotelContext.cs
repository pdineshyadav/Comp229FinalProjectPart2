namespace TeamProject2_Part1.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class HotelContext : DbContext
    {
        public HotelContext()
            : base("name=HotelConnection")
        {
        }

        public virtual DbSet<Appetizer> Appetizers { get; set; }
        public virtual DbSet<Dessert> Desserts { get; set; }
        public virtual DbSet<Soup> Soups { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appetizer>()
                .Property(e => e.AppetizerName)
                .IsUnicode(false);

            modelBuilder.Entity<Appetizer>()
                .Property(e => e.AppetizerDescription)
                .IsUnicode(false);

            modelBuilder.Entity<Appetizer>()
                .Property(e => e.AppetizerPrice)
                .IsUnicode(false);

            modelBuilder.Entity<Appetizer>()
                .Property(e => e.AppetizerImage)
                .IsUnicode(false);

            modelBuilder.Entity<Dessert>()
                .Property(e => e.DessertName)
                .IsUnicode(false);

            modelBuilder.Entity<Dessert>()
                .Property(e => e.DessertDescription)
                .IsUnicode(false);

            modelBuilder.Entity<Dessert>()
                .Property(e => e.DessertPrice)
                .IsUnicode(false);

            modelBuilder.Entity<Dessert>()
                .Property(e => e.DessertImage)
                .IsUnicode(false);

            modelBuilder.Entity<Soup>()
                .Property(e => e.SoupName)
                .IsUnicode(false);

            modelBuilder.Entity<Soup>()
                .Property(e => e.SoupDescription)
                .IsUnicode(false);

            modelBuilder.Entity<Soup>()
                .Property(e => e.SoupPrice)
                .IsUnicode(false);

            modelBuilder.Entity<Soup>()
                .Property(e => e.SoupImage)
                .IsUnicode(false);
        }
    }
}
