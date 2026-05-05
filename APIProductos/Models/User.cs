using Microsoft.AspNetCore.Identity;

namespace APIProductos.Models
{
    public class User : IdentityUser
    {
        public string Name { get; set; }

        public string? RefreshToken { get; set; }
        public DateTime? RefreshTokenExpiryTime { get; set; }
    }   
}
