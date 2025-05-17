using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infnet.EasyMediaLibrary.ConsoleApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infnet.EasyMediaLibrary.ConsoleApp.Infrastructure.Data
{
    public class MediaLibraryDbContext : DbContext
    {
        public DbSet<Midia> Midias { get; set; }
        public DbSet<Filme> Filmes { get; set; }
        public DbSet<Serie> Series { get; set; }
        public DbSet<Musica> Musicas { get; set; }
        public DbSet<Podcast> Podcasts { get; set; }

        public MediaLibraryDbContext() { }

        public MediaLibraryDbContext(DbContextOptions<MediaLibraryDbContext> options)
            : base(options) 
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=mediaLibrary.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Midia>(m =>
            {
                m.OwnsOne(m => m.Duracao, d =>
                {
                    d.Property(d => d.Minutos)
                        .HasColumnName("DuracaoMinutos")
                        .IsRequired();
                });

                // Configurar propriedades obrigatórias
                m.Property(m => m.Titulo).IsRequired();
                m.Property(m => m.Genero).IsRequired();
            });

            modelBuilder.Entity<Midia>()
                .HasDiscriminator<string>("TipoMidia")
                .HasValue<Filme>("Filme")
                .HasValue<Serie>("Serie")
                .HasValue<Musica>("Musica")
                .HasValue<Podcast>("Podcast");
        }
    }
}
