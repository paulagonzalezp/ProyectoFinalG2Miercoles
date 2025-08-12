using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Connect4API.Models
{
    public class Partida
    {
        public int Id { get; set; }

        [ForeignKey("Jugador1")]
        public int Jugador1_Id { get; set; }

        [ForeignKey("Jugador2")]
        public int Jugador2_Id { get; set; }

        public string Estado { get; set; } = string.Empty;

        public DateTime FechaHora { get; set; }

        public string Tablero { get; set; } = string.Empty; // Guardar como JSON el tablero
        public string Resultado { get; set; } = string.Empty;

        public int Turno { get; set; }

        // ✅ Propiedades de navegación (opcionalmente virtual para lazy loading)
        public virtual Jugador? Jugador1 { get; set; }
        public virtual Jugador? Jugador2 { get; set; }
    }
}
