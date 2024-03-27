using Microsoft.EntityFrameworkCore;

namespace Hierarchy
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<PessoaFisica> PessoasFisicas { get; set; }
        public DbSet<PessoaJuridica> PessoasJuridicas { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=hierarchy;User Id=postgres;Password=root;");
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Pessoa>().HasDiscriminator(pessoa => pessoa.Tipo)
                .HasValue<PessoaFisica>("PF")
                .HasValue<PessoaJuridica>("PJ");
            base.OnModelCreating(modelBuilder);
        }
    }
}
