using Microsoft.EntityFrameworkCore;
using Connect4API.Models;

namespace Connect4API.Data
{
    public class Connect4Context : DbContext
    {
        public Connect4Context(DbContextOptions<Connect4Context> options)
            : base(options)
        {
        }

        public DbSet<Jugador> Jugadores { get; set; }
        public DbSet<Partida> Partidas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Relación: Partida.Jugador1_Id → Jugador.Id
            modelBuilder.Entity<Partida>()
                .HasOne(p => p.Jugador1)
                .WithMany() // si quieres que un jugador tenga muchas partidas, cambia esto
                .HasForeignKey(p => p.Jugador1_Id)
                .OnDelete(DeleteBehavior.Restrict); // evita eliminación en cascada

            // Relación: Partida.Jugador2_Id → Jugador.Id
            modelBuilder.Entity<Partida>()
                .HasOne(p => p.Jugador2)
                .WithMany()
                .HasForeignKey(p => p.Jugador2_Id)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
