using Microsoft.AspNetCore.Mvc;
using CMS.Data;
using System.Linq;

namespace CMS.Backend.Controllers
{
    public class PostController : Controller
    {
        private readonly ApplicationDbContext _context;

        // Chỉ giữ DUY NHẤT một hàm khởi tạo (Constructor) để tiêm DB
        public PostController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Chỉ giữ DUY NHẤT một hàm Index() lấy dữ liệu thật
        public IActionResult Index()
        {
            var posts = _context.Posts.ToList();
            return View(posts);
        }
    }
}