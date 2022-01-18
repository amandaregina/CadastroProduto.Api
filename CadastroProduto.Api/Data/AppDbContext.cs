using CadastroProduto.Api.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace CadastroProduto.Api.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>()
                .HasKey(p => p.Id);

            modelBuilder.Entity<Produto>()
                .Property(p => p.Descricao)
                    .IsRequired();

            modelBuilder.Entity<Produto>()
                .Property(p => p.Codigo)
                    .IsRequired();

            modelBuilder.Entity<Produto>()
                .HasIndex(p => p.Codigo)
                    .IsUnique();

            modelBuilder.Entity<Produto>()
                .Property(p => p.Preco)
                    .HasPrecision(10, 2)
                    .IsRequired();

            modelBuilder.Entity<Produto>()
                .Property(p => p.Deletado)
                    .IsRequired()
                    .HasDefaultValue(false);

            modelBuilder.Entity<Produto>()
                .Property(p => p.Status)
                    .IsRequired()
                    .HasDefaultValue(true);

            modelBuilder.Entity<Produto>()
                .HasData(
                            new Produto { Id = Guid.Parse("120a0bd0-1ac0-8cd9-55c1-8ac501db680a"), Descricao = "Leite", Codigo = "1238585", Preco = 4, Deletado = false, Status = true },
                            new Produto { Id = Guid.Parse("870c0bd0-1bc0-4cd2-39c2-2ac551dc681c"), Descricao = "Manteiga", Codigo = "555566", Preco = 6, Deletado = false, Status = true });
        }
    }
}
