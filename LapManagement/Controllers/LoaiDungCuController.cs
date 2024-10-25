﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LapManagement.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using LabEquipmentManagement.Data;

namespace LapManagement.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class LoaiDungCuController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public LoaiDungCuController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/LoaiDungCu
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LoaiDungCu>>> GetLoaiDungCus()
        {
            return await _context.loaiDungCus.ToListAsync();
        }

        // GET: api/LoaiDungCu/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LoaiDungCu>> GetLoaiDungCu(string id)
        {
            var loaiDungCu = await _context.loaiDungCus.FindAsync(id);

            if (loaiDungCu == null)
            {
                return NotFound();
            }

            return loaiDungCu;
        }

        // POST: api/LoaiDungCu
        [HttpPost]
        public async Task<ActionResult<LoaiDungCu>> PostLoaiDungCu(LoaiDungCu loaiDungCu)
        {
            _context.loaiDungCus.Add(loaiDungCu);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetLoaiDungCu), new { id = loaiDungCu.MaLoaiDC }, loaiDungCu);
        }

        // PUT: api/LoaiDungCu/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLoaiDungCu(string id, LoaiDungCu loaiDungCu)
        {
            if (id != loaiDungCu.MaLoaiDC)
            {
                return BadRequest();
            }

            _context.Entry(loaiDungCu).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LoaiDungCuExists(id))
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

        // DELETE: api/LoaiDungCu/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLoaiDungCu(string id)
        {
            var loaiDungCu = await _context.loaiDungCus.FindAsync(id);
            if (loaiDungCu == null)
            {
                return NotFound();
            }

            _context.loaiDungCus.Remove(loaiDungCu);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool LoaiDungCuExists(string id)
        {
            return _context.loaiDungCus.Any(e => e.MaLoaiDC == id);
        }
    }
}
