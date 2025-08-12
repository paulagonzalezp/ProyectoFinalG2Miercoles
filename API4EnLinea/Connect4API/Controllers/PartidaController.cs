using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Connect4API.Data;
using Connect4API.Models;

namespace Connect4API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PartidaController : ControllerBase
    {
        private readonly Connect4Context _context;

        public PartidaController(Connect4Context context)
        {
            _context = context;
        }

        // Obtener todas las partidas con jugadores incluidos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Partida>>> GetPartidas()
        {
            return await _context.Partidas
                .Include(p => p.Jugador1)
                .Include(p => p.Jugador2)
                .ToListAsync();
        }

        // Obtener una partida específica con jugadores incluidos
        [HttpGet("{id}")]
        public async Task<ActionResult<Partida>> GetPartida(int id)
        {
            var partida = await _context.Partidas
                .Include(p => p.Jugador1)
                .Include(p => p.Jugador2)
                .FirstOrDefaultAsync(p => p.Id == id);

            if (partida == null)
                return NotFound();

            return partida;
        }

        // Crear una nueva partida
        [HttpPost]
        public async Task<IActionResult> PostPartida(Partida partida)
        {
            var jugador1 = await _context.Jugadores.FindAsync(partida.Jugador1_Id);
            var jugador2 = await _context.Jugadores.FindAsync(partida.Jugador2_Id);

            if (jugador1 == null || jugador2 == null)
                return BadRequest("Uno o ambos jugadores no existen.");

            partida.FechaHora = DateTime.UtcNow;
            partida.Estado = "En progreso";

            _context.Partidas.Add(partida);
            await _context.SaveChangesAsync();

            return Ok(new { message = "Partida agregada correctamente.", partida });
        }

        // Actualizar parcialmente una partida
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPartida(int id, [FromBody] PartidaUpdateDto dto)
        {
            var partida = await _context.Partidas.FindAsync(id);
            if (partida == null)
                return NotFound();

            if (dto.Estado != null)
                partida.Estado = dto.Estado;

            if (dto.Tablero != null)
                partida.Tablero = dto.Tablero;

            if (dto.Resultado != null)
                partida.Resultado = dto.Resultado;

            if (dto.Turno.HasValue)
                partida.Turno = dto.Turno.Value;

            await _context.SaveChangesAsync();
            return NoContent();
        }

        // Eliminar partida
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePartida(int id)
        {
            var partida = await _context.Partidas.FindAsync(id);
            if (partida == null)
                return NotFound();

            _context.Partidas.Remove(partida);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }

}
