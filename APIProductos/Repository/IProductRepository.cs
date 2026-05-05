using APIProductos.Models;

namespace APIProductos.Repository
{
    public interface IProductRepository
    {
        Task<List<Product>> GetAll();
        Task<Product?> GetById(int id);
        Task<Product> Create(Product product);
        Task Update(Product product);
        Task<bool> Delete(int id);
    }
}
