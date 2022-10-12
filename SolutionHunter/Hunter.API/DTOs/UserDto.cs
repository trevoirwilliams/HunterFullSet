using System.ComponentModel.DataAnnotations;

namespace Hunter.API.DTOs
{
    public class UserDto : LoginUserDto
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        [Required]
        public string? KnownAs { get; set; }

        [Required]
        public string? Role { get; set; }
    }
}
