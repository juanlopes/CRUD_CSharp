using DataAccessObject.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccessObject
{
    public class DataContext : DbContext
    {
        public DbSet<Anuncio> Anuncios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var parametros = new Parametros();
            optionsBuilder.UseMySQL($"server={parametros.getHost()};database=teste_webmotors;user={parametros.getUser()};password={parametros.getPassword()}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Anuncio>(entity =>
            {
                entity.HasKey(e => e.ID);
                entity.Property(e => e.marca).HasColumnName("marca");
                entity.Property(d => d.modelo).HasColumnName("modelo");
                entity.Property(d => d.versao).HasColumnName("versao");
                entity.Property(d => d.ano).HasColumnName("ano");
                entity.Property(d => d.quilometragem).HasColumnName("quilometragem");
                entity.Property(d => d.observacao).HasColumnName("observacao");
            });
        }
    }
}
