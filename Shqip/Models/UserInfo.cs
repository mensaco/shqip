using System.ComponentModel.DataAnnotations;

namespace Shqip.Models
{
    public class UserInfo
    {
        [Required]
        [EmailAddress]
        [MaxLength(50)]
        public string Email { get; set; }
        [Required]
        [MaxLength(30)]
        public string Password { get; set; }
    }
}
