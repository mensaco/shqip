using System.Threading.Tasks;

namespace Shqip.Auth
{
    public interface ILoginService
    {
        Task Login(string token);
        Task Logout();
    }
}
