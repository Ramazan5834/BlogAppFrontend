using BlogAppFrontend.ApiServices.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BlogAppFrontend.ViewComponents
{
    public class LastFiveBlog: ViewComponent
    {
        private IBlogApiService _blogApiService;
        public LastFiveBlog(IBlogApiService blogApiService)
        {
            _blogApiService = blogApiService;
        }
        public IViewComponentResult Invoke()
        {
            return View(_blogApiService.GetLastFiveAsync().Result);
        }
    }
}
