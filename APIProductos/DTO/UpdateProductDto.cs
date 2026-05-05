using System.ComponentModel.DataAnnotations;

namespace APIProductos.DTO
{
    public class UpdateProductDto
    {
        [Required]
        public string Name { get; set; }

        [Range(0, 100000)]
        public decimal Price { get; set; }

        [Range(0, 10000)]
        public int Stock { get; set; }
    }
}
