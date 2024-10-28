using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LabEquipmentManagement.Data;
using LapManagement.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LapManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChucVuController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ChucVuController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/ChucVu
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ChucVu>>> GetChucVus()
        {
            return await _context.chucVus.ToListAsync();
        }

        // GET: api/ChucVu/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<ChucVu>> GetChucVu(string id)
        {
            var chucVu = await _context.chucVus.FindAsync(id);

            if (chucVu == null)
            {
                return NotFound();
            }

            return chucVu;
        }

        // POST: api/ChucVu
        [HttpPost]
        public async Task<ActionResult<ChucVu>> PostChucVu(ChucVu chucVu)
        {
            _context.chucVus.Add(chucVu);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetChucVu), new { id = chucVu.MaCV }, chucVu);
        }

        // PUT: api/ChucVu/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutChucVu(string id, ChucVu chucVu)
        {
            if (id != chucVu.MaCV)
            {
                return BadRequest();
            }

            _context.Entry(chucVu).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ChucVuExists(id))
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

        // DELETE: api/ChucVu/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteChucVu(string id)
        {
            var chucVu = await _context.chucVus.FindAsync(id);
            if (chucVu == null)
            {
                return NotFound();
            }

            _context.chucVus.Remove(chucVu);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ChucVuExists(string id)
        {
            return _context.chucVus.Any(e => e.MaCV == id);
        }
    }
}
