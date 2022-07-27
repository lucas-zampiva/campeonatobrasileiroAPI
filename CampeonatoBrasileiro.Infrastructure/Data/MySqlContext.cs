using CampeonatoBrasileiro.Domain.Entitys;
using Microsoft.EntityFrameworkCore;

namespace CampeonatoBrasileiro.Infrastructure.Data
{
    public class MySqlContext : DbContext
    {
        public DbSet<Jogador> jogadores { get; set; }
        public DbSet<Time> times { get; set; }
        public DbSet<Transferencia> transferencias { get; set; }
        public DbSet<Torneio> torneios { get; set; }
        public DbSet<Partida> partidas { get; set; }
        public DbSet<Evento> eventos { get; set; }

        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options) => Database.EnsureCreated();

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("Data") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("Data").CurrentValue = DateTime.Now;
                }
                if (entry.State == EntityState.Modified)
                {
                    entry.Property("Data").IsModified = false;
                }
            }
            return base.SaveChanges();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Jogador>().ToTable("jogadores");
            builder.Entity<Jogador>().HasKey(j => j.Id);
            builder.Entity<Jogador>().Property(j => j.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Jogador>().Property(j => j.Nome).IsRequired().HasMaxLength(120);
            builder.Entity<Jogador>().Property(j => j.Pais).IsRequired();

            builder.Entity<Time>().ToTable("times");
            builder.Entity<Time>().HasKey(t => t.Id);
            builder.Entity<Time>().Property(t => t.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Time>().Property(t => t.Localidade).IsRequired().HasMaxLength(30);

            builder.Entity<Transferencia>().ToTable("transferencias");
            builder.Entity<Transferencia>().HasKey(t => t.Id);
            builder.Entity<Transferencia>().Property(t => t.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Transferencia>().Property(t => t.Data).IsRequired();
            builder.Entity<Transferencia>().Property(t => t.Valor).IsRequired();
            builder.Entity<Transferencia>().Property(t => t.TimeDestinoId).IsRequired();
            builder.Entity<Transferencia>().Property(t => t.TimeOrigemId).IsRequired();
            builder.Entity<Transferencia>().Property(t => t.JogadorId).IsRequired();

            builder.Entity<Torneio>().ToTable("torneios");
            builder.Entity<Torneio>().HasKey(t => t.Id);
            builder.Entity<Torneio>().Property(t => t.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Torneio>().Property(t => t.Nome).IsRequired();
            builder.Entity<Torneio>().Property(t => t.DataInicio).IsRequired();
            builder.Entity<Torneio>().Property(t => t.DataFim).IsRequired();

            //builder.Entity<TorneioTimes>().ToTable("timetorneio");
            builder.Entity<TorneioTime>().HasKey(t => new { t.TorneioId, t.TimeId });

            builder.Entity<Partida>().ToTable("partidas");
            builder.Entity<Partida>().HasKey(p => p.Id);
            builder.Entity<Partida>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Partida>().Property(p => p.NroPartida).IsRequired();
            builder.Entity<Partida>().Property(p => p.MandanteId).IsRequired();
            builder.Entity<Partida>().Property(p => p.VisitanteId).IsRequired();
            builder.Entity<Partida>().Property(p => p.TorneioId).IsRequired();

            builder.Entity<Evento>().ToTable("eventos");
            builder.Entity<Evento>().HasKey(t => t.Id);
            builder.Entity<Evento>().Property(t => t.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Evento>().Property(t => t.Mensagem).IsRequired();
            builder.Entity<Evento>().Property(t => t.TipoEvento).IsRequired();
            builder.Entity<Evento>().Property(t => t.TorneioId).IsRequired();
            builder.Entity<Evento>().Property(t => t.PartidaId).IsRequired();
            builder.Entity<Evento>().Property(t => t.Data).IsRequired();
        }
    }
}