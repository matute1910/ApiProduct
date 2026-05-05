using APIProductos.Data;
using APIProductos.Models;
using Microsoft.EntityFrameworkCore;

namespace APIProductos.Repository
{
    public class ProductRepository :IProductRepository
    {
        private readonly ProductDbContext _dbContext;
        public ProductRepository(ProductDbContext dbContext) 
        {
            _dbContext = dbContext;
        }


        public async Task<List<Product>> GetAll()
        {
            return await _dbContext.Products.ToListAsync();
        }

        public async Task<Product?> GetById(int id)
        {
            return await _dbContext.Products.FindAsync(id);
        }

        public async Task<Product> Create(Product product)
        {
            _dbContext.Products.Add(product);
            await _dbContext.SaveChangesAsync();
            return product;
        }

        public async Task Update(Product product)
        {
            _dbContext.Products.Update(product);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<bool> Delete(int id)
        {
            var product = await _dbContext.Products.FindAsync(id);

            if (product == null)
                return false;

            _dbContext.Products.Remove(product);
            await _dbContext.SaveChangesAsync();

            return true;
        }
    }
}
