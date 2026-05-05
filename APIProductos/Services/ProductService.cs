using APIProductos.DTO;
using APIProductos.Models;
using APIProductos.Repository;

namespace APIProductos.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<IEnumerable<ProductDto>> GetAll()
        {
            var products = await _productRepository.GetAll();

            return products.Select(p => new ProductDto
            {
                Id = p.Id,
                Name = p.Name,
                Price = p.Price
            });
        }

        public async Task<ProductDto?> GetById(int id)
        {
            var product = await _productRepository.GetById(id);

            if (product == null)
                return null;

            return new ProductDto
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price
            };
        }

        public async Task<ProductDto> Create(CreateProductDto dto)
        {
            var product = new Product
            {
                Name = dto.Name,
                Price = dto.Price,
                Stock = dto.Stock
            };

            var created = await _productRepository.Create(product);

            return new ProductDto
            {
                Id = created.Id,
                Name = created.Name,
                Price = created.Price
            };
        }

        public async Task<bool> Update(int id, UpdateProductDto dto)
        {
            var product = await _productRepository.GetById(id);

            if (product == null)
                return false;

            product.Name = dto.Name;
            product.Price = dto.Price;
            product.Stock = dto.Stock;

            await _productRepository.Update(product);

            return true;
        }

        public async Task<bool> Delete(int id)
        {
            return await _productRepository.Delete(id);
        }
    }
}
