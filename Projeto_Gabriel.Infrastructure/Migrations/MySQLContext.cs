using Microsoft.EntityFrameworkCore;
using Projeto_Gabriel.Domain.Entity;
using Projeto_Gabriel.Domain.Entity.Logas;
using Projeto_Gabriel.Domain.Entity.Mercadinho;

namespace Projeto_Gabriel.Model.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext()
        {

        }

        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options){}

        public DbSet<Usuario> Usuarios { get; set; }

        //Logs
        public DbSet<LogEntry> Logs { get; set; }

        // Mercadinho
        public DbSet<Caixa> Caixas { get; set; }
        public DbSet<MovimentacaoCaixa> MovimentacoesCaixa { get; set; }
        public DbSet<Venda> Vendas { get; set; }
        public DbSet<ItemVenda> ItensVenda { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<Categoria> Categorias { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Aplica todas as configurações de mapeamento encontradas no assembly
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MySQLContext).Assembly);
        }
    }
}