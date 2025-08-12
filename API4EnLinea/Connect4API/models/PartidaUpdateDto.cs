namespace Connect4API.Models
{
    public class PartidaUpdateDto
    {
        public string? Estado { get; set; }
        public string? Tablero { get; set; }
        public string? Resultado { get; set; }
        public int? Turno { get; set; }
    }
}
