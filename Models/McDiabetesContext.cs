using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BurgerAPI.Models
{
    public partial class McDiabetesContext : DbContext
    {
        public McDiabetesContext()
        {
        }

        public McDiabetesContext(DbContextOptions<McDiabetesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Burger> Burgers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=VCKNDHHSLP01\\SQLEXPRESS;Database=McDiabetes;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Burger>(entity =>
            {
                entity.ToTable("Burger");

                entity.Property(e => e.BurgerId).HasColumnName("BurgerID");

                entity.Property(e => e.Bun)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Patty)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
