using Microsoft.AspNetCore.Identity;

namespace Hunter.API.Data
{
    public class ApiUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? KnownAs { get; set; }

        // The following are already in IdentityUser
        // public int Id  { get; set; }
        // public string PhoneNumber { get; set; }
        // public string Email { get; set; }
        // public string UserName { get; set; }
        public string? Password { get; set; }
    }
}
