using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pruebitas.Data;
using Pruebitas.Models;

namespace Pruebitas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusicasController : ControllerBase
    {
        private readonly AppDbContext _context;

        public MusicasController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Musicas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Musica>>> GetMusica()
        {
            return await _context.Musica.ToListAsync();
        }

        // GET: api/Musicas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Musica>> GetMusica(string id)
        {
            var musica = await _context.Musica.FindAsync(id);

            if (musica == null)
            {
                return NotFound();
            }

            return musica;
        }

        // PUT: api/Musicas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMusica(string id, Musica musica)
        {
            if (id != musica.nombreCancion)
            {
                return BadRequest();
            }

            _context.Entry(musica).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MusicaExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Musicas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Musica>> PostMusica(Musica musica)
        {
            _context.Musica.Add(musica);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (MusicaExists(musica.nombreCancion))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetMusica", new { id = musica.nombreCancion }, musica);
        }

        // DELETE: api/Musicas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMusica(string id)
        {
            var musica = await _context.Musica.FindAsync(id);
            if (musica == null)
            {
                return NotFound();
            }

            _context.Musica.Remove(musica);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MusicaExists(string id)
        {
            return _context.Musica.Any(e => e.nombreCancion == id);
        }
    }
}
