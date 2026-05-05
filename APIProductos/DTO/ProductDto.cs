using System.ComponentModel.DataAnnotations;

namespace APIProductos.DTO
{
    public class ProductDto
    {
        public int Id { get; set; }
         
       [Required]
        public string Name { get; set; }

        [Required]
        [Range(1, 100000)]
        public decimal Price { get; set; }

        
    }
}
