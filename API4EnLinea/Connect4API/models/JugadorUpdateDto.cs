namespace Connect4API.Models
{
    public class JugadorUpdateDto
    {
        public int? Marcador { get; set; }
        public int? Ganadas { get; set; }
        public int? Perdidas { get; set; }
        public int? Empates { get; set; }
        public string? Nombre { get; set; }
    }
}