using System.Threading.Tasks;

namespace BlogAppFrontend.ApiServices.Interfaces
{
    public interface IImageApiService
    {
        Task<string> GetBlogImageByIdAsync(int id);
    }
}
