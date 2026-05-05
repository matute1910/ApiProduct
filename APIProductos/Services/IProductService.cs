using APIProductos.DTO;


namespace APIProductos.Services
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetAll();
        Task<ProductDto?> GetById(int id);
        Task<ProductDto> Create(CreateProductDto dto);
        Task<bool> Update(int id, UpdateProductDto dto);
        Task<bool> Delete(int id);
    }
}
