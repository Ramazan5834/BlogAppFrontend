using Microsoft.AspNetCore.Mvc;

namespace BlogAppFrontend.ViewComponents
{
    public class Search:ViewComponent
    {

        public IViewComponentResult Invoke(string s)
        {
            ViewBag.SearchString = s;
            return View();
        }
    }
}
