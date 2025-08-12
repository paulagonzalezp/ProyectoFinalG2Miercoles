using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Connect4API.Data;
using Connect4API.Models;

namespace Connect4API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class JugadorController : ControllerBase
    {
        private readonly Connect4Context _context;
        public JugadorController(Connect4Context context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Jugador>>> GetJugadores()
        {
            return await _context.Jugadores.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Jugador>> GetJugador(int id)
        {
            var jugador = await _context.Jugadores.FindAsync(id);
            if (jugador == null) return NotFound();
            return jugador;
        }

        [HttpPost]
        public async Task<ActionResult<Jugador>> PostJugador(Jugador jugador)
        {
            if (await _context.Jugadores.AnyAsync(j => j.Id == jugador.Id))
            {
                return Conflict(new { message = "Ya existe un jugador con ese Id." });
            }
            _context.Jugadores.Add(jugador);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetJugador), new { id = jugador.Id }, jugador);
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> PutJugador(int id, [FromBody] JugadorUpdateDto dto)
        {
            var jugador = await _context.Jugadores.FindAsync(id);
            if (jugador == null) return NotFound();

            // Solo actualiza lo que viene en el DTO
            if (dto.Nombre != null)
                jugador.Nombre = dto.Nombre;
            if (dto.Marcador.HasValue)
                jugador.Marcador = dto.Marcador.Value;
            if (dto.Ganadas.HasValue)
                jugador.Ganadas = dto.Ganadas.Value;
            if (dto.Perdidas.HasValue)
                jugador.Perdidas = dto.Perdidas.Value;
            if (dto.Empates.HasValue)
                jugador.Empates = dto.Empates.Value;

            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpPost("jugadorGanador/{id}")]
        public async Task<IActionResult> JugadorGanador(int id)
        {
            var jugador = await _context.Jugadores.FindAsync(id);
            if (jugador == null) return NotFound();

            jugador.Marcador += 1;
            jugador.Ganadas += 1;

            await _context.SaveChangesAsync();
            return Ok("Sumado");
        }

        [HttpPost("jugadorPerdedor/{id}")]
        public async Task<IActionResult> JugadorPerdedor(int id)
        {
            var jugador = await _context.Jugadores.FindAsync(id);
            if (jugador == null) return NotFound();

            jugador.Marcador -= 1;
            jugador.Perdidas += 1;

            await _context.SaveChangesAsync();
            return Ok("Actualizado");
        }

        [HttpPost("jugadorEmpate/{id}")]
        public async Task<IActionResult> JugadorEmpate(int id)
        {
            var jugador = await _context.Jugadores.FindAsync(id);
            if (jugador == null) return NotFound();

            jugador.Empates += 1;

            await _context.SaveChangesAsync();
            return Ok("Empate sumado");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJugador(int id)
        {
            var jugador = await _context.Jugadores.FindAsync(id);
            if (jugador == null) return NotFound();
            _context.Jugadores.Remove(jugador);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
