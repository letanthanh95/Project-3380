using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace ZooProjF.Models
{
    public partial class AppDbContext : IdentityDbContext
    {
        public DbSet<CustomerManagement> CustomerManagement { get; set; }
        public DbSet<Category> Categories { get; set; } 
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustomerManagement>(entity =>
            {
                entity.ToTable("Customer");
                entity.HasNoKey();
                //entity.HasKey(e => e.CustomerMangagementId)
                //      .HasName("Customer_ID");

                entity.Property(e => e.CustomerMangagementId)
                      .HasColumnType("int(11)");

                entity.Property(e => e.First_Name)
                      .IsRequired()
                      .HasMaxLength(32)
                      .IsUnicode(false);

                entity.Property(e => e.Last_Name)
                      .IsRequired()
                      .HasMaxLength(32)
                      .IsUnicode(false);

                entity.Property(e => e.Phone_Number)
                      .HasColumnType("int(10)");

                entity.Property(e => e.Email)
                      .IsRequired()
                      .HasMaxLength(255)
                      .IsUnicode(false);

                entity.Property(e => e.City)
                      .IsRequired()
                      .HasMaxLength(32)
                      .IsUnicode(false);

                entity.Property(e => e.State)
                      .IsRequired()
                      .HasMaxLength(32)
                      .IsUnicode(false);

                entity.Property(e => e.Zip_Code)
                      .HasColumnType("int");

                entity.Property(e => e.Street_Name)
                      .IsRequired()
                      .HasMaxLength(32)
                      .IsUnicode(false);
            });
        }
    }
}
