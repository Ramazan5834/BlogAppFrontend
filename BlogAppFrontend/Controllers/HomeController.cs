using System.Threading.Tasks;
using BlogAppFrontend.ApiServices.Interfaces;
using BlogAppFrontend.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlogAppFrontend.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBlogApiService _blogApiService;
        public HomeController(IBlogApiService blogApiService)
        {
            _blogApiService = blogApiService;
        }

        public async Task<IActionResult> Index(int? categoryId,string s)
        {
            if (categoryId.HasValue)
            {
                ViewBag.ActiveCategory = categoryId;
                return View(await _blogApiService.GetAllByCategoryIdAsync((int) categoryId));
            }
            if (!string.IsNullOrWhiteSpace(s))
            {
                ViewBag.SearchString = s;
                return View(await _blogApiService.SearchAsync(s));
            }
            return View(await _blogApiService.GetAllAsync());
        }

        public async Task<IActionResult> BlogDetail(int id)
        {
            ViewBag.Comments = await _blogApiService.GetCommentAsync(id, null);
            return View(await _blogApiService.GetByIdAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> AddToComment(CommentAddModel model)
        {
            await _blogApiService.AddToComment(model);
            return RedirectToAction("BlogDetail", new {id = model.BlogId});
        }
    }
}
