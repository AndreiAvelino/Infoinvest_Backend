using Domain.Ativo;
using Domain.Carteira;
using Domain.CarteiraAtivo;
using Domain.ClassificacaoAtivo;
using Domain.User;
using Microsoft.EntityFrameworkCore;

namespace Repository.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<CarteiraDAO> Carteira { get; set; }
        public DbSet<AtivoDAO> Ativo { get; set; }
        public DbSet<ClassificacaoAtivoDAO> ClassificacaoAtivo { get; set; }
        public DbSet<CarteiraAtivoDAO> CarteiraAtivo { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<CarteiraDAO>()
                .HasOne(c => c.Usuario)
                .WithMany(p => p.ListaCarteira)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
