using Microsoft.AspNetCore.Mvc;
using CMS.Data.Entities;

namespace CMS.Backend.Controllers
{
    public class PostController : Controller
    {
        public IActionResult Index()
        {
            var posts = new List<Post>
            {
                new Post
                {
                    Id = 1,
                    Title = "Lộ trình học ASP.NET Core",
                    Content = "Nội dung bài viết ASP.NET Core...",
                    ImageUrl = "https://via.placeholder.com/300",
                    CreatedDate = DateTime.Now
                },

                new Post
                {
                    Id = 2,
                    Title = "Cài đặt ReactJS",
                    Content = "Hướng dẫn cài ReactJS...",
                    ImageUrl = "https://via.placeholder.com/300",
                    CreatedDate = DateTime.Now.AddDays(-1)
                }
            };

            return View(posts);
        }

        public IActionResult Details(int id)
        {
            var post = new Post
            {
                Id = id,
                Title = "Chi tiết bài viết " + id,
                Content = "Đây là nội dung chi tiết bài viết...",
                ImageUrl = "https://via.placeholder.com/600x300",
                CreatedDate = DateTime.Now
            };

            return View(post);
        }
    }
}