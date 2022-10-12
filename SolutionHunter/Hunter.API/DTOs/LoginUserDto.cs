using System.ComponentModel.DataAnnotations;

namespace Hunter.API.DTOs
{
    public class LoginUserDto
    {
        [Required]
        public string? UserName { get; set; }

        [Required]
        public string? Password { get; set; }
    }
}
