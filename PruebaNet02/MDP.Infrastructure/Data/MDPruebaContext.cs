using MDP.Core.Entities;
using MDP.Infrastructure.Data.Configurations;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace MDP.Infrastructure.Data
{
    public partial class MDPruebaContext : DbContext
    {
        public MDPruebaContext()
        {
        }

        public MDPruebaContext(DbContextOptions<MDPruebaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cliente> Clientes { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClienteConfiguration());
        }

    }
}
