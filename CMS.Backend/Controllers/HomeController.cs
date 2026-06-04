using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CMS.Data; // Thư mục chứa cấu hình DbContext của bạn
using System.Linq;

namespace CMS.Backend.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        // Hàm khởi tạo để tiêm kết nối Database vào trang chủ
        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            // Cú pháp LINQ: Lọc, sắp xếp và cắt lấy đúng 3 bản tin mới nhất
            var latestPosts = _context.Posts
                                      .Include(p => p.Category) // Lấy kèm tên danh mục để hiển thị lên Card
                                      .OrderByDescending(p => p.CreatedDate) // Ngày đăng mới nhất xếp lên đầu
                                      .Take(3) // Chỉ bốc đúng 3 bài viết đầu tiên
                                      .ToList(); // Chốt hạ, thực thi câu lệnh truy vấn xuống SQL

            return View(latestPosts); // Gửi 3 bài viết ra View trang chủ
        }
    }
}