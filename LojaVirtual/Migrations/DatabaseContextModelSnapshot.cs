﻿// <auto-generated />
using System;
using LojaVirtual.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LojaVirtual.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("LojaVirtual.Models.Acesso.Usuario", b =>
                {
                    b.Property<uint>("IdUsuario")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(35);

                    b.Property<uint>("IdCliente");

                    b.Property<string>("Perfil")
                        .IsRequired()
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 1)))
                        .HasColumnType("CHAR(1)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.HasKey("IdUsuario");

                    b.HasIndex("IdCliente");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("LojaVirtual.Models.Cliente.Cliente", b =>
                {
                    b.Property<uint>("IdCliente")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasMaxLength(11);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("IdCliente");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("LojaVirtual.Models.Produto.Categoria", b =>
                {
                    b.Property<uint>("IdCategoria")
                        .ValueGeneratedOnAdd();

                    b.Property<uint?>("CategoriaPaiId");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("IdCategoria");

                    b.HasIndex("CategoriaPaiId");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("LojaVirtual.Models.Produto.Imagem", b =>
                {
                    b.Property<uint>("IdImagem")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Caminho")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<uint>("IdProduto");

                    b.HasKey("IdImagem");

                    b.HasIndex("IdProduto");

                    b.ToTable("Imagem");
                });

            modelBuilder.Entity("LojaVirtual.Models.Produto.Produto", b =>
                {
                    b.Property<uint>("IdProduto")
                        .ValueGeneratedOnAdd();

                    b.Property<uint>("Altura");

                    b.Property<uint>("Comprimento");

                    b.Property<string>("Cor")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<uint>("Estoque");

                    b.Property<string>("Fabricante")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.Property<uint>("IdCategoria");

                    b.Property<uint>("IdUsuario");

                    b.Property<uint>("Largura");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<float>("Peso")
                        .HasColumnType("FLOAT");

                    b.Property<float>("Valor")
                        .HasColumnType("FLOAT");

                    b.HasKey("IdProduto");

                    b.HasIndex("IdCategoria");

                    b.HasIndex("IdUsuario");

                    b.ToTable("Produto");
                });

            modelBuilder.Entity("LojaVirtual.Models.Venda.Carrinho", b =>
                {
                    b.Property<uint>("IdCarrinho")
                        .ValueGeneratedOnAdd();

                    b.Property<uint>("IdCliente");

                    b.Property<uint>("IdProduto");

                    b.Property<uint>("Quantidade");

                    b.HasKey("IdCarrinho");

                    b.HasIndex("IdCliente");

                    b.HasIndex("IdProduto");

                    b.ToTable("Carrinho");
                });

            modelBuilder.Entity("LojaVirtual.Models.Acesso.Usuario", b =>
                {
                    b.HasOne("LojaVirtual.Models.Cliente.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("IdCliente")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("LojaVirtual.Models.Produto.Categoria", b =>
                {
                    b.HasOne("LojaVirtual.Models.Produto.Categoria", "CategoriaPai")
                        .WithMany()
                        .HasForeignKey("CategoriaPaiId");
                });

            modelBuilder.Entity("LojaVirtual.Models.Produto.Imagem", b =>
                {
                    b.HasOne("LojaVirtual.Models.Produto.Produto", "Produto")
                        .WithMany("Imagem")
                        .HasForeignKey("IdProduto")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("LojaVirtual.Models.Produto.Produto", b =>
                {
                    b.HasOne("LojaVirtual.Models.Produto.Categoria", "Categoria")
                        .WithMany()
                        .HasForeignKey("IdCategoria")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("LojaVirtual.Models.Acesso.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("IdUsuario")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("LojaVirtual.Models.Venda.Carrinho", b =>
                {
                    b.HasOne("LojaVirtual.Models.Cliente.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("IdCliente")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("LojaVirtual.Models.Produto.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("IdProduto")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
