using System.Threading.Tasks;
using BlogAppFrontend.Models;

namespace BlogAppFrontend.ApiServices.Interfaces
{
    public interface IAuthApiService
    {
        Task<bool> SignIn(AppUserLoginModel model);
    }
}
