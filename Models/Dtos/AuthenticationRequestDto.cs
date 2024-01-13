using System.ComponentModel.DataAnnotations;

namespace AgendaApi.Models
{
    public class AuthenticationRequestDto
    {
        [Required]
        [EmailAddress]
        public string? Email { get; set; }
        [Required]
        public string? Password { get; set; }
    }
}
