using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using LabEquipmentManagement.Models;
using LabEquipmentManagement.Data;

namespace LabEquipmentManagement.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NguoiDungController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public NguoiDungController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/nguoidung
        [HttpGet]
        public async Task<ActionResult<IEnumerable<NguoiDung>>> GetUsers()
        {
            var users = await _context.NguoiDungs.ToListAsync();
            return Ok(users);
        }

        // GET: api/nguoidung/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<NguoiDung>> GetUser(int id)
        {
            var user = await _context.NguoiDungs.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        // POST: api/nguoidung
        [HttpPost]
        public async Task<ActionResult<NguoiDung>> PostUser(NguoiDung nguoiDung)
        {
            _context.NguoiDungs.Add(nguoiDung);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetUser), new { id = nguoiDung.UserID }, nguoiDung);
        }

        // PUT: api/nguoidung/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUser(int id, NguoiDung nguoiDung)
        {
            if (id != nguoiDung.UserID)
            {
                return BadRequest();
            }

            _context.Entry(nguoiDung).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/nguoidung/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var user = await _context.NguoiDungs.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            _context.NguoiDungs.Remove(user);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
