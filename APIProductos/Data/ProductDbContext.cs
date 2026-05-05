using APIProductos.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace APIProductos.Data
{
    public class ProductDbContext : IdentityDbContext<User>
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
        { }
        public DbSet<Product> Products { get; set; }
    }
}
