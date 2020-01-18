using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Shqip.Data
{
    /// <summary>
    /// Nje klase qe mundeson zgjerimin e IdentityUser me te dhena plotesuese per perdoruesin 
    /// </summary>
    public class ApplicationUser:IdentityUser
    {
        [MaxLength(30)]
        public string Titulli { get; set; }
        [MaxLength(30)]
        public string Vendbanimi { get; set; }

    }
}
