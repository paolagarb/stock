using Estoque.Models;
using Microsoft.EntityFrameworkCore;

namespace Estoque.Data
{
    public class EstoqueContext : DbContext
    {
        public EstoqueContext (DbContextOptions<EstoqueContext> options)
            : base(options)
        {
        }

        public DbSet<Produto> Produto { get; set; }
    }
}
