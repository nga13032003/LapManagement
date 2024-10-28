using Microsoft.AspNetCore.Mvc;
using LapManagement.Models;
using LabEquipmentManagement.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LapManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NhaCungCapController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public NhaCungCapController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/NhaCungCap
        [HttpGet]
        public async Task<ActionResult<IEnumerable<NhaCungCap>>> GetNhaCungCaps()
        {
            return await _context.nhaCungCaps.ToListAsync();
        }

        // GET: api/NhaCungCap/5
        [HttpGet("{id}")]
        public async Task<ActionResult<NhaCungCap>> GetNhaCungCap(string id)
        {
            var nhaCungCap = await _context.nhaCungCaps.FindAsync(id);

            if (nhaCungCap == null)
            {
                return NotFound();
            }

            return nhaCungCap;
        }

        // POST: api/NhaCungCap
        [HttpPost]
        public async Task<ActionResult<NhaCungCap>> PostNhaCungCap(NhaCungCap nhaCungCap)
        {
            _context.nhaCungCaps.Add(nhaCungCap);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetNhaCungCap), new { id = nhaCungCap.MaNCC }, nhaCungCap);
        }

        // PUT: api/NhaCungCap/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutNhaCungCap(string id, NhaCungCap nhaCungCap)
        {
            if (id != nhaCungCap.MaNCC)
            {
                return BadRequest();
            }

            _context.Entry(nhaCungCap).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NhaCungCapExists(id))
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

        // DELETE: api/NhaCungCap/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNhaCungCap(string id)
        {
            var nhaCungCap = await _context.nhaCungCaps.FindAsync(id);
            if (nhaCungCap == null)
            {
                return NotFound();
            }

            _context.nhaCungCaps.Remove(nhaCungCap);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool NhaCungCapExists(string id)
        {
            return _context.nhaCungCaps.Any(e => e.MaNCC == id);
        }
    }
}
