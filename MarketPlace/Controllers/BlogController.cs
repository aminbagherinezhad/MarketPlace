using MarketPlace.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MarketPlace.Controllers
{
    public class BlogController : Controller
    {

        private readonly IProductService _productService;
        public BlogController(IProductService productService)
        {
            _productService = productService;
        }
        //Show Blog
        //[HttpGet("blogs/{productId}/{title}")]
        //public async Task<IActionResult> BlogDetail(long productId, string title)
        //{
        //    var product = await _productService.GetBlogDetailById(productId);
        //    if (product == null) return NotFound();
        //    return View(product);
        //}
        [Route("BlogDetail/{id}")]
        public IActionResult BlogDetail(long id)
        {

            var course = _productService.GetBlogForShow(id);
            if (course == null)
            {
                return NotFound();
            }

            return View(course);

        }
    }
}
