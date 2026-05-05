using System.ComponentModel.DataAnnotations;

namespace APIProductos.DTO
{
    public class RegisterDto
    {

        [Required]
        public string Name { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [MinLength(6)]
        public string Password { get; set; }
    }
}
