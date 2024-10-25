using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using LabEquipmentManagement.Data;

namespace LapManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DatabaseConnectionTestController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public DatabaseConnectionTestController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/DatabaseConnectionTest
        [HttpGet]
        public async Task<ActionResult<string>> TestConnection()
        {
            try
            {
                // Thực hiện một truy vấn đơn giản
                var count = await _context.loaiDungCus.CountAsync();
                return Ok($"Kết nối thành công! Có {count} loại dụng cụ trong cơ sở dữ liệu.");
            }
            catch (DbUpdateException ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Kết nối thất bại: {ex.Message}");
            }
            catch (System.Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Có lỗi xảy ra: {ex.Message}");
            }
        }
    }
}
