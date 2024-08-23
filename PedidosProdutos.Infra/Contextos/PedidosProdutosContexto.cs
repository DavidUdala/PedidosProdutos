using Microsoft.EntityFrameworkCore;
using PedidosProdutos.Dominio.Entidades;

namespace PedidosProdutos.Infra.Contextos
{
    public class PedidosProdutosContexto : DbContext
    {
        public PedidosProdutosContexto(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Pedido> Pedido { get; set; }
        public DbSet<ItensPedido> ItensPedido { get; set; }
        public DbSet<Produto> Produto { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ItensPedido>()
                .HasOne(ip => ip.Pedido)
                .WithMany(p => p.ItensPedidos)
                .HasForeignKey(t => t.IdPedido);

            modelBuilder.Entity<ItensPedido>()
                .HasOne(ip => ip.Produto)
                .WithMany(p => p.ItensPedidos)
                .HasForeignKey(t => t.IdProduto);
        }
    }
}
