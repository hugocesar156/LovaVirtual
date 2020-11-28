﻿using LojaVirtual.Models.Acesso;
using LojaVirtual.Models.Cliente;
using LojaVirtual.Models.Pagamento;
using LojaVirtual.Models.Produto;
using LojaVirtual.Models.Venda;
using Microsoft.EntityFrameworkCore;

namespace LojaVirtual.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Imagem> Imagem { get; set; }
        public DbSet<Carrinho> Carrinho { get; set; }
        public DbSet<Parcelamento> Parcelamento { get; set; }
        public DbSet<Frete> Frete { get; set; }
        public DbSet<Pedido> Pedido { get; set; }
        public DbSet<ProdutoHistorico> ProdutoHistorico { get; set; }
    }
}
