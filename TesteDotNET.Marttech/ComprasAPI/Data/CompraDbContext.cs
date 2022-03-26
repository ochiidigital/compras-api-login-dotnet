using ComprasAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ComprasAPI.Data
{
    public class CompraDbContext : DbContext
    {
        public DbSet<Carrinho> Carrinhos { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        public CompraDbContext(DbContextOptions<CompraDbContext> options) 
            : base(options)
        {

        }
    }
}
