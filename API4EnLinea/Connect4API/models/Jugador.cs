namespace Connect4API.Models
{
    public class Jugador
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public int Marcador { get; set; } = 0;
        public int Ganadas { get; set; } = 0;
        public int Perdidas { get; set; } = 0;
        public int Empates { get; set; } = 0;
    }
}
