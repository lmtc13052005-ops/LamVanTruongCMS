using Microsoft.AspNetCore.Mvc;
using CMS.Data; // Đảm bảo có dòng này để hệ thống hiểu lớp ApplicationDbContext

namespace CMS.Backend.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _context;

        // Kỹ thuật Dependency Injection (DI): Hệ thống tự động rót kết nối Database vào đây
        public CategoryController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            // Lấy dữ liệu THẬT trực tiếp từ bảng Categories trong SQL Server
            var data = _context.Categories.ToList();
            return View(data);
        }
    }
}