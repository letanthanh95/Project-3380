using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Stripe;
using MySqlX.XDevAPI.Relational;
using System.Data.Entity.Infrastructure;

namespace ZooProjF.Models
{
    public partial class AppDbContext:IdentityDbContext
    {
        private readonly object modelBuilder;
        public DbSet<CustomerManagerment> CustomerManagerment { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustomerManagerment>(entity =>
            {
                entity.ToTable("Customer");

                entity.Property(e => e.Customer_ID)
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
           
            //modelBuilder.Seed();
        }
    }
}
