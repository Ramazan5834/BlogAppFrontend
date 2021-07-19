using BlogAppFrontend.ApiServices.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BlogAppFrontend.ViewComponents
{
    public class CategoryList : ViewComponent
    {
        private readonly ICategoryApiService _categoryApiService;
        public CategoryList(ICategoryApiService categoryApiService)
        {
            _categoryApiService = categoryApiService;
        }
        public IViewComponentResult Invoke()
        {
            var x = _categoryApiService.GetAllWithBlogsCount().Result;
            return View(x);
        }
    }
}