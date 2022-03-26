using ComprasAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ComprasAPI.Data
{
    public class CompraDbContext : DbContext
    {
        public DbSet<Carrinho> Carrinhos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Item> Itens { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Email> Emails { get; set; }
        public DbSet<Telefone> Telefones { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }

        public CompraDbContext(DbContextOptions<CompraDbContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Endereco>()
                .HasOne(e => e.Cliente)
                .WithOne(c => c.Endereco)
                .HasForeignKey<Endereco>(e => e.ClienteId);

            //builder.Entity<Email>()
            //    .HasOne(e => e.Cliente)
            //    .WithMany(c => c.Emails)
            //    .HasForeignKey(e => e.ClienteId);
            builder.Entity<Cliente>()
                .HasMany(c => c.Emails)
                .WithOne()
                .HasForeignKey(e => e.ClienteId);

            builder.Entity<Telefone>()
                .HasOne(t => t.Cliente)
                .WithMany(c => c.Telefones)
                .HasForeignKey(t => t.ClienteId);

            builder.Entity<Carrinho>()
                .HasOne(ca => ca.Cliente)
                .WithOne(cl => cl.Carrinho)
                .HasForeignKey<Carrinho>(ca => ca.ClienteId);

            builder.Entity<Carrinho>()
                .HasMany(c => c.Itens)
                .WithOne(i => i.Carrinho)
                .HasForeignKey(i => i.CarrinhoId);

            builder.Entity<Item>()
                .HasOne(i => i.Produto)
                .WithOne()
                .HasForeignKey<Item>(i => i.ProdutoId);
        }
    }
}
