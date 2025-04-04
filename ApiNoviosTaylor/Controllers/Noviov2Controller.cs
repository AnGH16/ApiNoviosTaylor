using ApiNoviosTaylor.Data;
using ApiNoviosTaylor.Model;
using Asp.Versioning;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiNoviosTaylor.Controllers
{
    [ApiController]
    [Authorize(Roles = "Admin")]
    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/tsnovios")]
    public class Noviov2Controller : ControllerBase
    {
        private readonly NoviosContext _context;
        public Noviov2Controller(NoviosContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Novio>>> GetNovios()
        {
            try
            {
                var novios = await _context.Novios
     .FromSqlRaw("SELECT Novio_ID, Nombre, Cancion, Profesion, Foto FROM Novios")
     .ToListAsync();

                var noviosMayusculas = novios.Select(n => new Novio
                {
                    Novio_ID = n.Novio_ID,
                    Nombre = n.Nombre?.ToUpper(),
                    Cancion = n.Cancion?.ToUpper(),
                    Profesion = n.Profesion,
                    Foto = n.Foto
                }).ToList();

                return Ok(noviosMayusculas);

            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error en el servidor: {ex.Message}");
            }
        }

    }
}
