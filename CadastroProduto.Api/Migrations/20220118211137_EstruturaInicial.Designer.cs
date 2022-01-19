﻿// <auto-generated />
using System;
using CadastroProduto.Api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CadastroProduto.Api.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220118211137_EstruturaInicial")]
    partial class EstruturaInicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.10");

            modelBuilder.Entity("CadastroProduto.Api.Models.Departamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.Property<Guid?>("ProdutoId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("ProdutoId");

                    b.ToTable("Departamento");
                });

            modelBuilder.Entity("CadastroProduto.Api.Models.Produto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<bool>("Deletado")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(false);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<decimal>("Preco")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.Property<bool>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(true);

                    b.HasKey("Id");

                    b.HasIndex("Codigo")
                        .IsUnique();

                    b.ToTable("Produtos");

                    b.HasData(
                        new
                        {
                            Id = new Guid("120a0bd0-1ac0-8cd9-55c1-8ac501db680a"),
                            Codigo = "1238585",
                            Deletado = false,
                            Descricao = "Leite",
                            Preco = 4m,
                            Status = true
                        },
                        new
                        {
                            Id = new Guid("870c0bd0-1bc0-4cd2-39c2-2ac551dc681c"),
                            Codigo = "555566",
                            Deletado = false,
                            Descricao = "Manteiga",
                            Preco = 6m,
                            Status = true
                        });
                });

            modelBuilder.Entity("CadastroProduto.Api.Models.Departamento", b =>
                {
                    b.HasOne("CadastroProduto.Api.Models.Produto", null)
                        .WithMany("Departamento")
                        .HasForeignKey("ProdutoId");
                });

            modelBuilder.Entity("CadastroProduto.Api.Models.Produto", b =>
                {
                    b.Navigation("Departamento");
                });
#pragma warning restore 612, 618
        }
    }
}
