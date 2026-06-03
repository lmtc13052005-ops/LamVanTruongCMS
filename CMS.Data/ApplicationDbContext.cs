using Microsoft.EntityFrameworkCore;
using CMS.Data.Entities;

namespace CMS.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        // Khai báo đầy đủ 8 bảng dữ liệu theo đúng tài liệu hướng dẫn
        public DbSet<Category> Categories { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<CategoryProduct> CategoriesProducts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Nạp dữ liệu mẫu cho bảng User để khớp với danh sách Buổi 1
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Username = "admin_thai", FullName = "Nguyễn Cao Thái", Role = "Administrator" },
                new User { Id = 2, Username = "editor_01", FullName = "Trần Văn Biên Tập", Role = "Editor" },
                new User { Id = 3, Username = "author_minh", FullName = "Lê Quang Minh", Role = "Author" }
            );
        }
    }
}