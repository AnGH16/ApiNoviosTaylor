using ApiNoviosTaylor.Data;
using Microsoft.AspNetCore.Mvc;
using ApiNoviosTaylor.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
namespace ApiNoviosTaylor.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/tsnovios")]
    public class NovioController : ControllerBase
    {
        private readonly NoviosContext _context;
        public NovioController(NoviosContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Novio>>> GetNovios()
        {
            try
            {
                var novios = await _context.Novios.FromSqlRaw("Exec VerBfs").ToListAsync();
                return Ok(novios);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error en el servidor: {ex.Message}");
            }
        }

        [HttpGet("{novio_id}")]
        public async Task<ActionResult<List<Novio>>> GetNoviosById([FromRoute] int novio_id)
        {
            try
            {
                var novios = await _context.Novios.FromSqlRaw("Exec VerbfsId @p0", novio_id).ToListAsync();
                return Ok(novios);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error interno: {ex.Message}");
            }
        }

        [HttpPut("{novio_id}")]
        public async Task<ActionResult<List<Novio>>> UpdateNovio([FromRoute] int novio_id, [FromBody] Novio novio)
        {
            try
            {
                var response = await _context.Database.ExecuteSqlRawAsync(
                  "Exec UpdateBf @p0, @p1, @p2, @p3, @p4",
                    novio_id, novio?.Nombre, novio?.Cancion, novio?.Profesion, novio?.Foto
                );

                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error interno: {ex.Message}");
            }
        }

        [HttpDelete("{novio_id}")]
        public async Task<IActionResult> DeleteNovio([FromRoute]int novio_id)
        {
            try
            {
                await _context.Database.ExecuteSqlRawAsync("Exec DeleteBf @p0", novio_id);
                return Ok($"Novio con ID {novio_id} eliminado correctamente.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error interno: {ex.Message}");
            }
        }

        [HttpPost]
        public async Task<ActionResult<List<Novio>>> CrearNovio(Novio novio) 
        {
            try
            {
                var response = await _context.Database.ExecuteSqlRawAsync(
                  "Exec AgregarBf @p0, @p1, @p2, @p3",
                   novio?.Nombre, novio?.Cancion, novio?.Profesion, novio?.Foto
                );

                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error interno: {ex.Message}");
            }
        }
    }
}
