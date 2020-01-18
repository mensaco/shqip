using System;
using System.ComponentModel.DataAnnotations;

namespace Shqip.Models
{
    public class UserToken
    {
        [MaxLength(511)]
        public string Token { get; set; }
        public DateTime Expiration { get; set; }
    }
}
