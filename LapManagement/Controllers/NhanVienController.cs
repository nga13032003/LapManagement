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
    public class NhanVienController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public NhanVienController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/NhanVien
        [HttpGet]
        public async Task<ActionResult<IEnumerable<NhanVien>>> GetNhanViens()
        {
            return await _context.nhanViens.Include(nv => nv.ChucVu).Include(nv => nv.NhomQuyen).ToListAsync();
        }

        // GET: api/NhanVien/5
        [HttpGet("{id}")]
        public async Task<ActionResult<NhanVien>> GetNhanVien(string id)
        {
            var nhanVien = await _context.nhanViens
                .Include(nv => nv.ChucVu)
                .Include(nv => nv.NhomQuyen)
                .FirstOrDefaultAsync(nv => nv.MaNV == id);

            if (nhanVien == null)
            {
                return NotFound();
            }

            return nhanVien;
        }

        // POST: api/NhanVien
        [HttpPost]
        public async Task<ActionResult<NhanVien>> PostNhanVien(NhanVien nhanVien)
        {
            _context.nhanViens.Add(nhanVien);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetNhanVien), new { id = nhanVien.MaNV }, nhanVien);
        }

        // PUT: api/NhanVien/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutNhanVien(string id, NhanVien nhanVien)
        {
            if (id != nhanVien.MaNV)
            {
                return BadRequest();
            }

            _context.Entry(nhanVien).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NhanVienExists(id))
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

        // DELETE: api/NhanVien/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNhanVien(string id)
        {
            var nhanVien = await _context.nhanViens.FindAsync(id);
            if (nhanVien == null)
            {
                return NotFound();
            }

            _context.nhanViens.Remove(nhanVien);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool NhanVienExists(string id)
        {
            return _context.nhanViens.Any(e => e.MaNV == id);
        }
    }
}
