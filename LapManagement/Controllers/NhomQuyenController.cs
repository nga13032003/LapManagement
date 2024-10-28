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
    public class NhomQuyenController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public NhomQuyenController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/NhomQuyen
        [HttpGet]
        public async Task<ActionResult<IEnumerable<NhomQuyen>>> GetNhomQuyens()
        {
            return await _context.nhomQuyens.ToListAsync();
        }

        // GET: api/NhomQuyen/5
        [HttpGet("{id}")]
        public async Task<ActionResult<NhomQuyen>> GetNhomQuyen(string id)
        {
            var nhomQuyen = await _context.nhomQuyens.FindAsync(id);

            if (nhomQuyen == null)
            {
                return NotFound();
            }

            return nhomQuyen;
        }

        // POST: api/NhomQuyen
        [HttpPost]
        public async Task<ActionResult<NhomQuyen>> PostNhomQuyen(NhomQuyen nhomQuyen)
        {
            _context.nhomQuyens.Add(nhomQuyen);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetNhomQuyen), new { id = nhomQuyen.MaNhom }, nhomQuyen);
        }

        // PUT: api/NhomQuyen/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutNhomQuyen(string id, NhomQuyen nhomQuyen)
        {
            if (id != nhomQuyen.MaNhom)
            {
                return BadRequest();
            }

            _context.Entry(nhomQuyen).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NhomQuyenExists(id))
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

        // DELETE: api/NhomQuyen/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNhomQuyen(string id)
        {
            var nhomQuyen = await _context.nhomQuyens.FindAsync(id);
            if (nhomQuyen == null)
            {
                return NotFound();
            }

            _context.nhomQuyens.Remove(nhomQuyen);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool NhomQuyenExists(string id)
        {
            return _context.nhomQuyens.Any(e => e.MaNhom == id);
        }
    }
}
