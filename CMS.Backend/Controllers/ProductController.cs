using Microsoft.AspNetCore.Mvc;
using CMS.Data;
using System.Linq;

namespace CMS.Backend.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Lấy danh sách sản phẩm từ bảng Products
        public IActionResult Index()
        {
            var products = _context.Products.ToList();
            return View(products);
        }
    }
}