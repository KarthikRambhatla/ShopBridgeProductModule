using Microsoft.EntityFrameworkCore;
using ShopBridgeProductModule.Models;

namespace ShopBridgeProductModule.Data
{
    public class ProductDBContext:DbContext
    {
        public ProductDBContext(DbContextOptions<ProductDBContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; } = null!;
    }
}
