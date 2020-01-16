using Microsoft.AspNetCore.Identity;

namespace Shqip.Data
{
    /// <summary>
    /// Nje klase qe mundeson zgjerimin e IdentityUser me te dhena plotesuese per perdoruesin 
    /// </summary>
    public class ApplicationUser:IdentityUser
    {

        public string Titulli { get; set; }
        public string Vendbanimi { get; set; }

    }
}
