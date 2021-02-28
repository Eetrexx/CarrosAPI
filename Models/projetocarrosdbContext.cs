using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace CarrosAPI.Models
{
    public partial class projetocarrosdbContext : DbContext
    {
        public projetocarrosdbContext()
        {
        }

        public projetocarrosdbContext(DbContextOptions<projetocarrosdbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Carro> Carros { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=tcp:projetocarrosdb.database.windows.net,1433;Initial Catalog=projetocarrosdb;Persist Security Info=False;User ID=projetocarros;Password=carros123!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Carro>(entity =>
            {
                entity.ToTable("carros");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Cor)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("cor");

                entity.Property(e => e.DataAquisicao)
                    .HasColumnType("date")
                    .HasColumnName("data_aquisicao");

                entity.Property(e => e.Dono)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dono");

                entity.Property(e => e.Marca)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("marca");

                entity.Property(e => e.Modelo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("modelo");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
